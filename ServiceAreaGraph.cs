using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServicesApp
{
    public class ServiceAreaConnection
    {
        public string From { get; set; }
        public string To { get; set; }
        public int Distance { get; set; }

        public ServiceAreaConnection(
            string from, string to, int distance)
        {
            From = from;
            To = to;
            Distance = distance;
        }
    }

    public class ServiceAreaGraph
    {
        private readonly Dictionary<string, List<string>> adjacency =
            new Dictionary<string, List<string>>(
                StringComparer.OrdinalIgnoreCase);

        private readonly List<ServiceAreaConnection> connections =
            new List<ServiceAreaConnection>();

        public void AddArea(string area)
        {
            if (string.IsNullOrWhiteSpace(area))
                throw new ArgumentException("Area name is required.");

            if (!adjacency.ContainsKey(area))
                adjacency.Add(area, new List<string>());
        }

        public void AddConnection(
            string from, string to, int distance)
        {
            if (distance < 0)
                throw new ArgumentException(
                    "Distance cannot be negative.");

            AddArea(from);
            AddArea(to);

            if (string.Equals(
                from, to, StringComparison.OrdinalIgnoreCase))
            {
                throw new ArgumentException(
                    "An area cannot connect to itself.");
            }

            bool exists = connections.Any(edge =>
                (edge.From.Equals(from,
                    StringComparison.OrdinalIgnoreCase) &&
                 edge.To.Equals(to,
                    StringComparison.OrdinalIgnoreCase)) ||
                (edge.From.Equals(to,
                    StringComparison.OrdinalIgnoreCase) &&
                 edge.To.Equals(from,
                    StringComparison.OrdinalIgnoreCase)));

            if (exists)
                throw new ArgumentException(
                    "This connection already exists.");

            adjacency[from].Add(to);
            adjacency[to].Add(from);

            connections.Add(
                new ServiceAreaConnection(from, to, distance));
        }

        // Breadth-First Search (BFS)
        public List<string> BreadthFirstSearch(string start)
        {
            List<string> visitedOrder = new List<string>();

            if (!adjacency.ContainsKey(start))
                return visitedOrder;

            HashSet<string> visited =
                new HashSet<string>(
                    StringComparer.OrdinalIgnoreCase);

            Queue<string> queue = new Queue<string>();

            visited.Add(start);
            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                string current = queue.Dequeue();
                visitedOrder.Add(current);

                foreach (string neighbour in adjacency[current])
                {
                    if (visited.Add(neighbour))
                        queue.Enqueue(neighbour);
                }
            }

            return visitedOrder;
        }

        // Depth-First Search (DFS)
        public List<string> DepthFirstSearch(string start)
        {
            List<string> visitedOrder = new List<string>();

            if (!adjacency.ContainsKey(start))
                return visitedOrder;

            HashSet<string> visited =
                new HashSet<string>(
                    StringComparer.OrdinalIgnoreCase);

            Stack<string> stack = new Stack<string>();
            stack.Push(start);

            while (stack.Count > 0)
            {
                string current = stack.Pop();

                if (!visited.Add(current))
                    continue;

                visitedOrder.Add(current);

                // Reverse insertion order so traversal is predictable.
                for (int i = adjacency[current].Count - 1;
                     i >= 0; i--)
                {
                    string neighbour = adjacency[current][i];

                    if (!visited.Contains(neighbour))
                        stack.Push(neighbour);
                }
            }

            return visitedOrder;
        }

        // Kruskal's algorithm for a minimum spanning tree.
        public List<ServiceAreaConnection> MinimumSpanningTree()
        {
            List<ServiceAreaConnection> result =
                new List<ServiceAreaConnection>();

            Dictionary<string, string> parent =
                new Dictionary<string, string>(
                    StringComparer.OrdinalIgnoreCase);

            Dictionary<string, int> rank =
                new Dictionary<string, int>(
                    StringComparer.OrdinalIgnoreCase);

            foreach (string area in adjacency.Keys)
            {
                parent[area] = area;
                rank[area] = 0;
            }

            List<ServiceAreaConnection> sortedConnections =
                connections
                    .OrderBy(edge => edge.Distance)
                    .ToList();

            foreach (ServiceAreaConnection edge in sortedConnections)
            {
                string rootFrom = Find(parent, edge.From);
                string rootTo = Find(parent, edge.To);

                if (!rootFrom.Equals(
                    rootTo, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(edge);
                    Union(parent, rank, rootFrom, rootTo);
                }

                if (result.Count == adjacency.Count - 1)
                    break;
            }

            return result;
        }

        private string Find(
            Dictionary<string, string> parent, string area)
        {
            if (!parent[area].Equals(
                area, StringComparison.OrdinalIgnoreCase))
            {
                parent[area] = Find(parent, parent[area]);
            }

            return parent[area];
        }

        private void Union(
            Dictionary<string, string> parent,
            Dictionary<string, int> rank,
            string first, string second)
        {
            string rootFirst = Find(parent, first);
            string rootSecond = Find(parent, second);

            if (rootFirst.Equals(
                rootSecond, StringComparison.OrdinalIgnoreCase))
                return;

            if (rank[rootFirst] < rank[rootSecond])
            {
                parent[rootFirst] = rootSecond;
            }
            else if (rank[rootFirst] > rank[rootSecond])
            {
                parent[rootSecond] = rootFirst;
            }
            else
            {
                parent[rootSecond] = rootFirst;
                rank[rootFirst]++;
            }
        }

        public int AreaCount
        {
            get { return adjacency.Count; }
        }

        public int ConnectionCount
        {
            get { return connections.Count; }
        }


        public static void RunExample()
        {
            ServiceAreaGraph graph = new ServiceAreaGraph();

            graph.AddConnection("Town Centre", "Residential Area", 4);
            graph.AddConnection("Town Centre", "Industrial Area", 3);
            graph.AddConnection("Residential Area", "Hospital Area", 5);
            graph.AddConnection("Industrial Area", "Hospital Area", 2);
            graph.AddConnection("Residential Area", "Industrial Area", 1);

            List<string> bfs =
                graph.BreadthFirstSearch("Town Centre");

            List<string> dfs =
                graph.DepthFirstSearch("Town Centre");

            List<ServiceAreaConnection> mst =
                graph.MinimumSpanningTree();

            System.Diagnostics.Debug.WriteLine(
                "BFS: " + string.Join(" -> ", bfs));

            System.Diagnostics.Debug.WriteLine(
                "DFS: " + string.Join(" -> ", dfs));

            int totalDistance = 0;

            foreach (ServiceAreaConnection edge in mst)
            {
                System.Diagnostics.Debug.WriteLine(
                    edge.From + " - " + edge.To +
                    ": " + edge.Distance);

                totalDistance += edge.Distance;
            }

            System.Diagnostics.Debug.WriteLine(
                "Total MST distance: " + totalDistance);
        }

    }
}