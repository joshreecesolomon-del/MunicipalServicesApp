using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServicesApp
{
    public class RequestPriorityHeap
    {
        private readonly List<Issue> heap = new List<Issue>();

        public int Count
        {
            get { return heap.Count; }
        }

        private int GetPriority(Issue issue)
        {
            switch (issue.Status)
            {
                case "Submitted":
                    return 3;

                case "In Progress":
                    return 2;

                case "Completed":
                    return 1;

                default:
                    return 0;
            }
        }

        private bool HasHigherPriority(Issue first, Issue second)
        {
            int firstPriority = GetPriority(first);
            int secondPriority = GetPriority(second);

            if (firstPriority != secondPriority)
                return firstPriority > secondPriority;

            // For equal priorities, older requests come first.
            return first.DateReported < second.DateReported;
        }

        public void Enqueue(Issue issue)
        {
            if (issue == null)
                return;

            heap.Add(issue);

            int child = heap.Count - 1;

            while (child > 0)
            {
                int parent = (child - 1) / 2;

                if (!HasHigherPriority(heap[child], heap[parent]))
                    break;

                Swap(child, parent);
                child = parent;
            }
        }

        public Issue Peek()
        {
            if (heap.Count == 0)
                return null;

            return heap[0];
        }

        public Issue Dequeue()
        {
            if (heap.Count == 0)
                return null;

            Issue highestPriority = heap[0];
            int lastIndex = heap.Count - 1;

            heap[0] = heap[lastIndex];
            heap.RemoveAt(lastIndex);

            int parent = 0;

            while (true)
            {
                int left = (parent * 2) + 1;
                int right = (parent * 2) + 2;
                int highest = parent;

                if (left < heap.Count &&
                    HasHigherPriority(heap[left], heap[highest]))
                {
                    highest = left;
                }

                if (right < heap.Count &&
                    HasHigherPriority(heap[right], heap[highest]))
                {
                    highest = right;
                }

                if (highest == parent)
                    break;

                Swap(parent, highest);
                parent = highest;
            }

            return highestPriority;
        }

        private void Swap(int first, int second)
        {
            Issue temporary = heap[first];
            heap[first] = heap[second];
            heap[second] = temporary;
        }

        public List<Issue> GetPriorityOrder(
            IEnumerable<Issue> requests)
        {
            heap.Clear();

            foreach (Issue issue in requests)
            {
                Enqueue(issue);
            }

            List<Issue> orderedRequests = new List<Issue>();

            while (Count > 0)
            {
                orderedRequests.Add(Dequeue());
            }

            return orderedRequests;
        }
    }
}