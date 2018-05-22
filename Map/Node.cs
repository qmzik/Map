using System;
using System.Collections.Generic;

namespace MapSpace
{
    public class Node
    {
        public char Letter { get; private set; }
        public string Value { get; set; }
        public Node parent;

        private LinkedList<Node> children;

        public Node(char letter = ' ')
        {
            Letter = letter;
            Value = null;
            children = new LinkedList<Node>();
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
            children.AddLast(child);

            return child;
        }

        public void DeleteChild(Node child)
        {
            children.Remove(child);
        }
    }
}
