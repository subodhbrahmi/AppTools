using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Run
{
    class ReverseByWord
    {
        string[] InpStr=new string[10];

        public void RevStrWrd(string TestStr)
        {
            //InpStr = TestStr.ToArray();
            //InpStr=TestStr.Split((string[]) null, StringSplitOptions.RemoveEmptyEntries);
            //InpStr = string.Join(" ", TestStr.Split(' ').Reverse());
            Console.WriteLine(string.Join(" ",TestStr.Split(' ').Reverse()));
            //Console.WriteLine(InpStr);
            
        }
    }
}
