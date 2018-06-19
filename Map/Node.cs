using System;
using System.Collections.Generic;

namespace MapSpace
{
    public class Node
    {
        public char Letter { get; private set; }
        public string Value { get; set; }
        public Node parent;

        public SortedDictionary<char, Node> children;

        public Node(char letter = '\0')
        {
            Letter = letter;
            Value = null;
            children = new SortedDictionary<char, Node>();
            parent = null;
        }

        public Node GetChild(char letter, bool createIfNotExist = false)
        {
            Node foundChild = new Node();
            if(children.TryGetValue(letter, out foundChild))
            {
                return foundChild;
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
            children.Add(letter, child);

            return child;
        }
    }
}
