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
            int TrgtNum, ttlCnt;
            //ReverseString rs = new ReverseString();
            //ReverseByWord rs = new ReverseByWord();
            //Console.Write("Input String = ");
            //inputstr=Console.ReadLine();
            //rs.RevStrWrd(inputstr);
            //rs.print("testing");
            //Console.WriteLine("Reversed String = " + rs.RevStr(inputstr));
            //Console.WriteLine("Reversed String = " + rs.RevStrWrd(inputstr));
            //Console.WriteLine("Reversed String = " + rs.RevStrbyIndex(inputstr));

            Console.WriteLine("Enter the number till when need to count the prime number = ");
            CntPrime cp = new CntPrime();
            TrgtNum = Convert.ToInt32(Console.ReadLine());
            ttlCnt=cp.CntNum(TrgtNum);
            Console.WriteLine("Total number of prime number till {0} is {1}", TrgtNum, ttlCnt);
            Console.ReadKey();

        }
    }
}
