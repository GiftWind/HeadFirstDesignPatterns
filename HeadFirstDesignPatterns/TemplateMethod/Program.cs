﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Tea myTea = new Tea();
            myTea.PrepareRecipe();
            Console.ReadLine();

        }
    }
}
