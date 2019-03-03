using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingAveragesExercise4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a grade. ");
            int gradeInRange = int.Parse(Console.ReadLine());
            int gradeCount = 0;
            int gradePointAverage = 0;

            while (gradeInRange >= 0 && gradeInRange <= 100 && gradeInRange != 0)
            {
                gradePointAverage += gradeInRange;
                gradeCount++;
                Console.WriteLine("Please enter another grade. Press 0 to terminate and see your GPA");
                gradeInRange = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Your average  is : {0} out of a possible 100%", gradePointAverage / gradeCount);

            int StudentGPA = gradePointAverage / gradeCount;

            if (StudentGPA >= 90 && StudentGPA <= 100)
            {
                Console.WriteLine("Your Final grade is an A.");
            }
            else if (StudentGPA >= 80)
            {
                Console.WriteLine("Your Final grade is an B.");
            }
            else if (StudentGPA >= 70)
            {
                Console.WriteLine("Your Final grade is an C.");
            }
            else if (StudentGPA >= 60)
            {
                Console.WriteLine("Your Final grade is an D.");
            }
            else if (StudentGPA <= 59)
            {
                Console.WriteLine("You have failed this course.");
            }



        }


    }

}
