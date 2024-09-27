using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Chars_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textage = "23";
            int age = Convert.ToInt32(textage);
            Console.WriteLine(age);

            string textbigNumber = "900000000";
            long bigNumber = Convert.ToInt64(textbigNumber);
            Console.WriteLine(bigNumber);

            string textNeg = "-52.22";
            double neg = Convert.ToDouble(textNeg);
            Console.WriteLine(neg);

            string textpres = "5.0000";
            float pres = Convert.ToSingle(textpres);
            Console.WriteLine(pres);

            string textmon = "11.99";
            decimal mon = Convert.ToDecimal(textmon);
            Console.WriteLine(mon);

            Console.ReadLine();
        }
    }
}