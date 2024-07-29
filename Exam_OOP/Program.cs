using Exam_OOP.MainQuestion;
using System.Diagnostics;

namespace Exam_OOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Any Id That Refer To Any Subject 
            Subject s1 = new (1, "C#");

            // Create Exam
            s1.CreateExam();

            
            Console.Write("Do You Want To start Your Exam Now ? (Y | N) : ");
            char choice = char.Parse(Console.ReadLine());
            if (choice == 'Y' || choice == 'y')
            {
                Console.Clear();
                // Built In C# 
                Stopwatch sw = new();
                sw.Start();

                s1.SubjectExam.ShowExam();
                Console.WriteLine($" \n Taken Time = {sw.Elapsed}");
            }
            else
            {
                Console.WriteLine("Thank You !");
            }
        }
    }
}
