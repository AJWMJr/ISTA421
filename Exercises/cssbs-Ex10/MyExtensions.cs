using System;
using System.Collections.Generic;
using System.Text;

namespace cssbs_Ex10
{
    public static class MyExtensions
    {
        public static int[] digitArr(this int n)
        {
            int[] result = new int[numDigits(n)];
            for (int i = result.Length - 1; i >= 0; i--)
            {
                result[i] = n % 10;
                n /= 10;
            }
            return result;
        }
        public static int numDigits(int n)
        {
            int i;
            for (i = 1; n > 9; i++)
            {
                n /= 10;
            }
            return i;
        }
        public static int Decimal(this int input, int baseInt)
        {
            int dec = 0;
            int[] arr = input.digitArr();
            if (baseInt == 2)
            {
                for (int i = 0; i < arr.Length; i++)
                    dec += arr[i] * Convert.ToInt32(Math.Pow(2, i));
                return dec;
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                    dec += arr[i] * Convert.ToInt32(Math.Pow(8, i));
                return dec;
            }
        }
        public static int Binary(this int input, int baseInt)
        {
            int bin = 0;
            if (baseInt == 8)
                input = input.Decimal(8);
            for (int i = 1; input >= 1; i *= 10)
            {
                bin += (input % 2) * i;
                input /= 2;
            }
            return bin;
        }
        public static int Octal(this int input, int baseInt)
        {
            int bin = 0;
            if (baseInt == 2)
                input = input.Decimal(2);
            for (int i = 1; input >= 1; i *= 10)
            {
                bin += (input % 8) * i;
                input /= 8;
            }
            return bin;
        }
    }
}
