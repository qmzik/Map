using System;

namespace MapSpace
{
    public class Map
    {
        private Node head;

        public Map()
        {
            head = new Node();
        }

        public void AddWord(string key, string value)
        {
            Node current = head;

            current = current.GetChild(key[0], true);

            for (int i = 1; i < key.Length; i++)
            {
                current = current.GetChild(key[i], true);
            }

            if (current.Value != null)
                throw new ArgumentException("This key is already exist");

            current.Value = value;
        }

        public string FindWord(string key)
        {
            return FindChildByKey(key).Value;
        }

        public void Delete(string key)
        {
            var removableChild = FindChildByKey(key);

            Node parent = null;
            while (parent != head)
            {
                parent = removableChild.parent;
                parent.DeleteChild(removableChild);
                removableChild = parent;
            }
        }

        public string this[string key]
        {
            get => FindWord(key);
            set { AddWord(key, value); }
        }


        private Node FindChildByKey(string key)
        {
            Node current = head;

            current = current.GetChild(key[0]);

            for (int i = 1; i < key.Length; i++)
            {
                current = current.GetChild(key[i]);
            }

            return current;
        }
    }
}