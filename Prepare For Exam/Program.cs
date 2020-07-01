using System;

namespace Prepare_For_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGrates = int.Parse(Console.ReadLine());

            int CountBadGrades = 0;
            int count = 0;
            double average = 0;
            string lastTask = string.Empty;


            while (CountBadGrades <= badGrates)
            {
                string taskName = Console.ReadLine();

                if (taskName == "Enough")
                {

                    Console.WriteLine($"Average score: {average / count:F2} ");
                    Console.WriteLine($"Number of problems: {count}");
                    Console.WriteLine($"Last problem: {lastTask}");
                    break;
                }
                lastTask = taskName;
                int gradeOfTask = int.Parse(Console.ReadLine());
                average += gradeOfTask;
                if (gradeOfTask <= 4)
                {
                    CountBadGrades++;
                }

                if (CountBadGrades == badGrates)
                {
                    Console.WriteLine($"You need a break, {badGrates} poor grades.");
                    break;
                }

                count++;
            }


        }
    }
}
