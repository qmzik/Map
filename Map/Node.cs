using System;
using System.Collections.Generic;

namespace MapSpace
{
    public class Node
    {
        public char Letter { get; private set; }
        public string Value { get; set; }
        public Node parent;

        private SortedSet<Node> children;

        public Node(char letter = '\0')
        {
            Letter = letter;
            Value = null;
            children = new SortedSet<Node>();
            parent = null;
        }

        public Node GetChild(char letter, bool createIfNotExist = false)
        {
            foreach (var child in children)
            {
                if (child.Letter == letter)
                {
                    return child;
                }
            }

            if (createIfNotExist)
            {
                return CreateChild(letter);
            }
            else
            {
                throw new ArgumentException("Key is not found");
            }
        }

        public Node CreateChild(char letter)
        {
            var child = new Node(letter)
            {
                parent = this
            };
            children.Add(child);

            return child;
        }

        public void DeleteChild(Node child)
        {
            children.Remove(child);
        }
    }
}
