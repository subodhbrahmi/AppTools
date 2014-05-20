using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run
{
    

    class ReverseString
    {
        char[] inputstr, outputstr;
        string reversed;

        public string RevStr(string name)
        {
            inputstr = name.ToCharArray();
            for (int i = 0; i < name.Length; i++)
            {
                for (int j = name.Length-1; j >= 0; j--)
                {
                    outputstr[i] = inputstr[j];
                }
            }

            return reversed;
        }
        public void print(string name)
        {
            Console.WriteLine(name);
        }
    }
}
