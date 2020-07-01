using System;

namespace Foot_Steps
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = 0;
            int goal = 10000;

            while (steps <= goal)
            {
                string command = Console.ReadLine();
                if (command == "Going home")
                {
                    steps += int.Parse(Console.ReadLine());
                    if (steps >= goal)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                    }
                    else
                    {
                        int diff = goal - steps;
                        Console.WriteLine($"{diff} more steps to reach goal.");
                        break;
                    }
                }
                else
                {
                    steps += int.Parse(command);
                    if (steps >= goal)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                    }
                }

            }
        }
    }
}
