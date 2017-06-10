using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the bit at postions P in the number N

            int p = 3;              // position
            int n = 42;             // number                   00101010
            int shifted = (n >> p); // shift right p positions  00000101
            int result = shifted & 1;   // compare with 1       00000001
            Console.WriteLine(result);

            // Clear the bits at position P
            p = 5;
            n = 42;                 //   00101010
            int mask = ~(1 << p);   // ~(00100000) = 11011111
            result = n & mask;      //   00001010


            n = 42;                      // 00000000 00101010
            int nMultipledBy32 = n << 5; // 00000101 01000000
            Console.WriteLine(nMultipledBy32); // 1344

            n = 56;                      // 00111000
            int bit4 = 1 << 4;           // 00010000
            Console.WriteLine((n & bit4) == bit4 ? "access granted" : "access denied");
        }
    }
}
