using System;

namespace MapSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map();
            map["0"] = "000";
            map["00"] = "000";
            map.Delete("0");
            Console.WriteLine(map["0"]);
            Console.ReadKey();
        }
    }
}
