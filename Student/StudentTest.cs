using System;

namespace Student
{
    internal class StudentTest
    {
        static void Main(string[] args)
        {

            Student student1 = new Student("Patryk",93);
            Student student2 = new Student("Kacper", 72);
           
            Console.WriteLine($"{student1.Name}'s letter grade equivalent of " + $"{student1.Average} is {student1.LetterGrade}");
            Console.WriteLine($"{student2.Name}'s letter grade equivalent of " + $"{student2.Average} is {student2.LetterGrade}");
        }
    }
}
