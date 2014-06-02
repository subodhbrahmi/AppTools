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
        string OutStr;

        public string RevStrWrd(string TestStr)
        {
            //InpStr = TestStr.ToArray();
            //InpStr=TestStr.Split((string[]) null, StringSplitOptions.RemoveEmptyEntries);
            //InpStr = string.Join(" ", TestStr.Split(' ').Reverse());
            OutStr=string.Join(" ",TestStr.Split(' ').Reverse());
            return OutStr;
            //Console.WriteLine(InpStr);

            
        }
    }
}
