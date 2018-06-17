using System;

namespace MapSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Map trie = new Map();
            trie["    "] = "1";
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
