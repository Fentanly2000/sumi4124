﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class p110
    {
        static void Main3424234(string[] args)
        {
            Console.WriteLine(int.Parse("52"));
            Console.WriteLine(long.Parse("273"));
            Console.WriteLine(float.Parse("52.273"));
            Console.WriteLine(double.Parse("103.32"));

            Console.WriteLine(int.Parse("52").GetType());
            Console.WriteLine(long.Parse("273").GetType());
            Console.WriteLine(float.Parse("52.274").GetType());
            Console.WriteLine(double.Parse("103.32").GetType());
        }
    }
}
