using System;
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
            string inputstr;
            //ReverseString rs = new ReverseString();
            ReverseByWord rs = new ReverseByWord();
            Console.Write("Input String = ");
            inputstr=Console.ReadLine();
            //rs.RevStrWrd(inputstr);
            //rs.print("testing");
            //Console.WriteLine("Reversed String = " + rs.RevStr(inputstr));
            //Console.WriteLine("Reversed String = " + rs.RevStrWrd(inputstr));
            Console.WriteLine("Reversed String = " + rs.RevStrbyIndex(inputstr));
            Console.ReadKey();

        }
    }
}
