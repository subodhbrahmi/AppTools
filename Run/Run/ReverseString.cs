using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run
{

    class ReverseString
    {
        char[] inputstr;
        char[] outputstr=new char[10];
        string reversed;

        public string RevStr(string name)
        {
            inputstr = name.ToCharArray();
            
            
                for (int i=0, j = name.Length-1; j >= 0; i++, j--)
                {
                    if (inputstr[j] == null)
                        break;
                    outputstr[i] = inputstr[j];
                }

            return new string(outputstr);
        }

    }
}
