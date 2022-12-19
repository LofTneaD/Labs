using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    internal static class Task5_2
    {
        public static void Run()
        {
            string str = Console.ReadLine()!;

            IsNumber(str);
            int sum = SumDigit(str);
            Console.WriteLine(sum);

        }
        public static int SumDigit(string str)
        {
            int sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char @char = str[i];
                int digit = @char - '0';
                sum += digit;
            }
            return sum;
        }
        public static bool IsNumber(string s)
        {
            int offset;
            if (s[0] == '-')
            {
                offset = 1;
            }
            else
            {
                offset = 0;
            }
            for (; offset < s.Length; offset++)
            {
                if (!(s[offset] >= '0' && s[offset] <= '9'))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
