﻿using System;

namespace MapSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map();
            map["mam"] = "000";
            map["mama"] = "000";
            map.Delete("mam");
            Console.ReadKey();
        }
    }
}
