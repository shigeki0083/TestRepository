﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!\n");
            Console.WriteLine(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));

            Console.WriteLine("Edit on web browser.");

            // キー入力待ち
            var key = Console.ReadKey();
        }
    }
}
