using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eratosthen
{
    public class Eratosthen
    {
        public Eratosthen()
        {

        }

        public List<string> GetPrimes(int maximum)
        {
            List<string> primes = new List<string>();

            bool[] boolArray = new bool[maximum];

            boolArray[0] = true;
            boolArray[1] = true;

            for (int i = 2; i < Math.Floor(Math.Sqrt(maximum)) + 1; i++)
            {
                if (!boolArray[i])
                {
                    for (int j = i + i; j < maximum ; j = j + i)
                    {
                        boolArray[j] = true;
                    }
                }
            }

            for (int i = 2; i < maximum; i++)
            {
                if (!boolArray[i])
                {
                    primes.Add(i.ToString());
                }
            }

            return primes;
        }
    }

    
}
