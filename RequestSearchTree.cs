using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServicesApp
{
    public class RequestSearchTree
    {
        private class Node
        {
            public string Key;
            public Issue Value;
            public Node Left;
            public Node Right;

            public Node(Issue issue)
            {
                Key = issue.RequestId;
                Value = issue;
            }
        }

        private Node root;

        public void Insert(Issue issue)
        {
            if (issue == null ||
                string.IsNullOrWhiteSpace(issue.RequestId))
            {
                return;
            }

            root = InsertNode(root, issue);
        }

        private Node InsertNode(Node node, Issue issue)
        {
            if (node == null)
                return new Node(issue);

            int comparison = string.Compare(
                issue.RequestId,
                node.Key,
                StringComparison.OrdinalIgnoreCase);

            if (comparison < 0)
                node.Left = InsertNode(node.Left, issue);
            else if (comparison > 0)
                node.Right = InsertNode(node.Right, issue);
            else
                node.Value = issue;

            return node;
        }

        public Issue Search(string requestId)
        {
            Node current = root;

            while (current != null)
            {
                int comparison = string.Compare(
                    requestId,
                    current.Key,
                    StringComparison.OrdinalIgnoreCase);

                if (comparison == 0)
                    return current.Value;

                current = comparison < 0
                    ? current.Left
                    : current.Right;
            }

            return null;
        }
    }
}
