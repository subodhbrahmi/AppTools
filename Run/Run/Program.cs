﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Run
{
    class Program
    {
        static void Main(string[] args)
        {

            ReverseString rs = new ReverseString();
            rs.print("testing");
            Console.WriteLine(rs.RevStr("Subodh"));
            Console.ReadKey();

        }
    }
}
