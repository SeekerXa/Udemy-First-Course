using System;


namespace StudentsClassAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int gradeCounter = 0;
            int grade = 0;



            while (grade != -1)
            {

               
                Console.Write("Enter grade or -1 to quit: ");
                grade = int.Parse(Console.ReadLine());
                if (grade == -1) break;
                total = total + grade;
                gradeCounter++;
            }

            if (gradeCounter != 0)
            {
                double average = (double)total / gradeCounter;
                Console.WriteLine($"\nTotal of grades is {gradeCounter}\nGrades entered is {total} \nClasses Average is {average:F}");
            }
            else
            {
                Console.WriteLine("No grades were entered");

            }
        }
    }
}                                                                                                 
