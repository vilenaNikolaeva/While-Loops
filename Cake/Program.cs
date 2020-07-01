using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            int totalcakePieces = lenght * hight;


            while (totalcakePieces > 0)
            {
                string input = Console.ReadLine();

                if (input == "STOP")
                {
                    Console.WriteLine($"{totalcakePieces} pieces are left.");
                    break;
                }
                totalcakePieces -= int.Parse(input);
            }
            if (totalcakePieces <= 0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(totalcakePieces)} pieces more.");
            }
        }
    }
}
