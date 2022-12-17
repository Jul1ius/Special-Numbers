using System;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                int currentNum = i;
                bool isSpecial = true;

                while (currentNum > 0)
                {
                    int lastDigit = currentNum % 10;
                    currentNum /= 10;
                    if (lastDigit == 0)
                    {
                        isSpecial = false;
                        break;
                    }

                    if (num % lastDigit != 0)
                    {
                        isSpecial = false;
                        break;
                    }
                }
                if (isSpecial)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
