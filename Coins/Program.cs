using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());
            double lv = Math.Floor(change);
            double coins = Math.Round((change - lv) * 100);
            double count = 0;

            while (lv > 0)
            {

                if (lv >= 2)
                {
                    count += 1;
                    lv -= 2;
                }
                else if (lv >= 1)
                {
                    count += 1;
                    lv -= 1;
                }
            }
            while (coins > 0)
            {
                if (coins >= 50)
                {
                    count += 1;
                    coins -= 50;
                }
                else if (coins >= 20)
                {
                    count += 1;
                    coins -= 20;
                }
                else if (coins >= 10)
                {
                    count += 1;
                    coins -= 10;
                }
                else if (coins >= 05)
                {
                    count += 1;
                    coins -= 05;
                }
                else if (coins >= 02)
                {
                    count += 1;
                    coins -= 02;
                }
                else if (coins >= 01)
                {
                    count += 1;
                    coins -= 01;
                }
            }
            Console.WriteLine(count);
        }
    }
}
