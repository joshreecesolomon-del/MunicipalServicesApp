using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServicesApp
{
    public class RequestAvlTree
    {
        private class Node
        {
            public string Key;
            public Issue Value;
            public Node Left;
            public Node Right;
            public int Height;

            public Node(Issue issue)
            {
                Key = issue.RequestId;
                Value = issue;
                Height = 1;
            }
        }

        private Node root;

        public int TreeHeight
        {
            get { return GetHeight(root); }
        }

        private int GetHeight(Node node)
        {
            return node == null ? 0 : node.Height;
        }

        private int GetBalance(Node node)
        {
            return node == null
                ? 0
                : GetHeight(node.Left) - GetHeight(node.Right);
        }

        private void UpdateHeight(Node node)
        {
            node.Height = 1 + Math.Max(
                GetHeight(node.Left),
                GetHeight(node.Right));
        }

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
            {
                node.Left = InsertNode(node.Left, issue);
            }
            else if (comparison > 0)
            {
                node.Right = InsertNode(node.Right, issue);
            }
            else
            {
                // Update an existing request with the same ID.
                node.Value = issue;
                return node;
            }

            UpdateHeight(node);

            int balance = GetBalance(node);

            // Left-Left case
            if (balance > 1 &&
                string.Compare(issue.RequestId, node.Left.Key,
                    StringComparison.OrdinalIgnoreCase) < 0)
            {
                return RotateRight(node);
            }

            // Right-Right case
            if (balance < -1 &&
                string.Compare(issue.RequestId, node.Right.Key,
                    StringComparison.OrdinalIgnoreCase) > 0)
            {
                return RotateLeft(node);
            }

            // Left-Right case
            if (balance > 1 &&
                string.Compare(issue.RequestId, node.Left.Key,
                    StringComparison.OrdinalIgnoreCase) > 0)
            {
                node.Left = RotateLeft(node.Left);
                return RotateRight(node);
            }

            // Right-Left case
            if (balance < -1 &&
                string.Compare(issue.RequestId, node.Right.Key,
                    StringComparison.OrdinalIgnoreCase) < 0)
            {
                node.Right = RotateRight(node.Right);
                return RotateLeft(node);
            }

            return node;
        }

        private Node RotateRight(Node y)
        {
            Node x = y.Left;
            Node subtree = x.Right;

            x.Right = y;
            y.Left = subtree;

            UpdateHeight(y);
            UpdateHeight(x);

            return x;
        }

        private Node RotateLeft(Node x)
        {
            Node y = x.Right;
            Node subtree = y.Left;

            y.Left = x;
            x.Right = subtree;

            UpdateHeight(x);
            UpdateHeight(y);

            return y;
        }

        public Issue Search(string requestId)
        {
            if (string.IsNullOrWhiteSpace(requestId))
                return null;

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