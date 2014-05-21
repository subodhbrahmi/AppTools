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
            ReverseString rs = new ReverseString();
            Console.Write("Input String = ");
            inputstr=Console.ReadLine();
            //rs.print("testing");
            Console.WriteLine("Reversed String = " + rs.RevStr(inputstr));
            Console.ReadKey();

        }
    }
}
