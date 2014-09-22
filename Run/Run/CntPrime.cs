using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run
{
    class CntPrime
    {
        public int CntNum(int n)  /*Function check for the number, and return the total count of prime number */
        {
            int cnt = 0;
            for (int num=2; num<=n; num++)
            {
                if (IsPrime(num))
                    cnt++;
            }
            return cnt;
        }

        bool IsPrime(int chkNum)
        {
            if (chkNum == 2)
                return true;

            else
            {
                int rem;
                double sqrt = Math.Sqrt(chkNum);
                for (int test = 2; test <= sqrt; test++)
                {
                    rem = chkNum % test;
                    if (rem == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }


    }
}
