using System;

namespace MapSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Map trie = new Map();
            trie["lol"] = "kek";
            Console.WriteLine(trie["lol"]);
            trie.Delete("lol");
            Console.ReadKey();
        }
    }
}
