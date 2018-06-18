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
            if (String.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentException("Cannot add empty key");
            }

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
            var foundedChild = FindChildByKey(key);
            if (foundedChild.Value == null)
                throw new ArgumentException("Key is not found");

            return foundedChild.Value;
        }

        public void Delete(string key)
        {
            var removableChild = FindChildByKey(key);

            if(removableChild.Value == null)
            {
                throw new ArgumentException("This key is not exist");
            }

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
            if (String.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentException("The map cannot contain an empty key");
            }

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