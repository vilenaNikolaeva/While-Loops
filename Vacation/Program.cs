using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double moneyHave = double.Parse(Console.ReadLine());

            int moneyCounter = 0;
            int daysCounter = 0;

            while (moneyHave < moneyNeeded && moneyCounter < 5)
            {
                string command = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());

                if (command == "spend")
                {
                    moneyHave -= money;
                    moneyCounter += 1;

                    if (moneyHave <= 0)
                    {
                        moneyHave = 0;
                    }

                }
                else if (command == "save")
                {
                    moneyHave += money;
                    moneyCounter = 0;

                }
                daysCounter++;
            }
            if (moneyCounter == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(daysCounter);
            }
            if (moneyHave >= moneyNeeded)
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }
        }
    }
}
