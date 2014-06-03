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

        //Function using IndexOf and LastIndexOf string operations

        public string RevStrbyIndex(string TestStr)
        {
            string chkSpace = " ";
            int InpLen = TestStr.Length;
            string tempStr="";
            int index;
            index = TestStr.LastIndexOf(chkSpace);
            for (int i = InpLen; index != -1; i-=index)
            {
                tempStr = tempStr + " " + TestStr.Substring(index + 1, i-(index+1));
                index=TestStr.LastIndexOf(chkSpace, index-1);
                   /* if(TestStr[index].ToString() == chkSpace)
                    {
                        tempStr = tempStr + TestStr.Substring(index + 1, i);

                    }*/
              }
            tempStr = tempStr + " " + TestStr.Substring(0, TestStr.IndexOf(chkSpace));
            //OutStr=tempStr;
        return tempStr;    
        }

            
     }


}
