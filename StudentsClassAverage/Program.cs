using System;


namespace StudentsClassAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int gradeCounter = 1;
            
            while (gradeCounter <= 10)
            {
                Console.Write("Enter grade: ");
                int grade = int.Parse(Console.ReadLine());
                total = total + grade;
                gradeCounter++;

            }

            int average = total / 10;
            Console.WriteLine($"\nTotal of all 10 grades is {total} \nClasses Average is {average}");

        }
    }
}                                                                                                 
