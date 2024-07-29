using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP.MainQuestion
{
    public class Subject
    {
        #region Constructors
        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }
        #endregion

        #region Property
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public ShapeExam SubjectExam { get; set; }
        #endregion


        #region Method
        public void CreateExam()
        {
            // 1- Time

            int time;
            do
            {
                Console.WriteLine("Enter Time Of Exam");
            } while (!int.TryParse(Console.ReadLine(), out time));

            // 2- Number Of Questions
            int questions;
            do
            {
                Console.WriteLine("Enter Number Of Questions : ");
            } while (!int.TryParse(Console.ReadLine(), out questions));

            // Type Of Exam
            int ExamType;
            do
            {
                Console.WriteLine("Enter Type Of Exam [1] For Practical AND [2] For Final");
            } while (!int.TryParse(Console.ReadLine(), out ExamType));

            if (ExamType == 1) // Practical
            {
                SubjectExam = new PracticalExam(time, questions);
            }
            else
            {
                SubjectExam = new FinalExam(time, questions);
            }
            Console.Clear();

            SubjectExam.CreateListOfQuestions();
        } 
        #endregion
    }
}
