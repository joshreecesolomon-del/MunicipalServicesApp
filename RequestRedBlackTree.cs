using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServicesApp
{
    public class RequestRedBlackTree
    {
        private class Node
        {
            public string Key;
            public Issue Value;
            public bool IsRed;
            public Node Left;
            public Node Right;
            public Node Parent;
        }

        private readonly Node nil;
        private Node root;

        public int Count { get; private set; }

        public RequestRedBlackTree()
        {
            nil = new Node();
            nil.IsRed = false;

            nil.Left = nil;
            nil.Right = nil;
            nil.Parent = nil;

            root = nil;
            Count = 0;
        }

        public void Insert(Issue issue)
        {
            if (issue == null ||
                string.IsNullOrWhiteSpace(issue.RequestId))
            {
                return;
            }

            Node parent = nil;
            Node current = root;

            while (current != nil)
            {
                parent = current;

                int comparison = string.Compare(
                    issue.RequestId,
                    current.Key,
                    StringComparison.OrdinalIgnoreCase);

                if (comparison == 0)
                {
                    current.Value = issue;
                    return;
                }

                current = comparison < 0
                    ? current.Left
                    : current.Right;
            }

            Node newNode = new Node
            {
                Key = issue.RequestId,
                Value = issue,
                IsRed = true,
                Left = nil,
                Right = nil,
                Parent = parent
            };

            if (parent == nil)
            {
                root = newNode;
            }
            else if (string.Compare(
                newNode.Key,
                parent.Key,
                StringComparison.OrdinalIgnoreCase) < 0)
            {
                parent.Left = newNode;
            }
            else
            {
                parent.Right = newNode;
            }

            Count++;
            FixInsertion(newNode);
        }

        private void FixInsertion(Node node)
        {
            while (node.Parent.IsRed)
            {
                if (node.Parent == node.Parent.Parent.Left)
                {
                    Node uncle = node.Parent.Parent.Right;

                    // Case 1: the uncle is red.
                    if (uncle.IsRed)
                    {
                        node.Parent.IsRed = false;
                        uncle.IsRed = false;
                        node.Parent.Parent.IsRed = true;
                        node = node.Parent.Parent;
                    }
                    else
                    {
                        // Case 2: triangle shape.
                        if (node == node.Parent.Right)
                        {
                            node = node.Parent;
                            RotateLeft(node);
                        }

                        // Case 3: line shape.
                        node.Parent.IsRed = false;
                        node.Parent.Parent.IsRed = true;
                        RotateRight(node.Parent.Parent);
                    }
                }
                else
                {
                    // Mirror the cases on the right side.
                    Node uncle = node.Parent.Parent.Left;

                    if (uncle.IsRed)
                    {
                        node.Parent.IsRed = false;
                        uncle.IsRed = false;
                        node.Parent.Parent.IsRed = true;
                        node = node.Parent.Parent;
                    }
                    else
                    {
                        if (node == node.Parent.Left)
                        {
                            node = node.Parent;
                            RotateRight(node);
                        }

                        node.Parent.IsRed = false;
                        node.Parent.Parent.IsRed = true;
                        RotateLeft(node.Parent.Parent);
                    }
                }
            }

            root.IsRed = false;
            root.Parent = nil;
        }

        private void RotateLeft(Node node)
        {
            Node rightChild = node.Right;
            node.Right = rightChild.Left;

            if (rightChild.Left != nil)
                rightChild.Left.Parent = node;

            rightChild.Parent = node.Parent;

            if (node.Parent == nil)
            {
                root = rightChild;
            }
            else if (node == node.Parent.Left)
            {
                node.Parent.Left = rightChild;
            }
            else
            {
                node.Parent.Right = rightChild;
            }

            rightChild.Left = node;
            node.Parent = rightChild;
        }

        private void RotateRight(Node node)
        {
            Node leftChild = node.Left;
            node.Left = leftChild.Right;

            if (leftChild.Right != nil)
                leftChild.Right.Parent = node;

            leftChild.Parent = node.Parent;

            if (node.Parent == nil)
            {
                root = leftChild;
            }
            else if (node == node.Parent.Right)
            {
                node.Parent.Right = leftChild;
            }
            else
            {
                node.Parent.Left = leftChild;
            }

            leftChild.Right = node;
            node.Parent = leftChild;
        }

        public Issue Search(string requestId)
        {
            if (string.IsNullOrWhiteSpace(requestId))
                return null;

            Node current = root;

            while (current != nil)
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
