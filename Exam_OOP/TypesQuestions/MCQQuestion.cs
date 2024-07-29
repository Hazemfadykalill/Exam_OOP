using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam_OOP.MainQuestion;

namespace Exam_OOP.TypesQuestions
{
     class MCQQuestion : BaseQuestion
    {
        #region Constructors
        public MCQQuestion()
        {
            AnswerList = new Answers[3];
        }
        #endregion
        #region Property
        public override string HeaderOfQuestion1 => "MCQ Question";
        #endregion



        #region Method
        public override void AddQuestion()
        {
            // Header
            Console.WriteLine(HeaderOfQuestion1);
            //---------------------------------------------------------------------------------

            // Body
            Console.WriteLine("Enter Body Of Question : ");
            BodyOfQuestion1 = Console.ReadLine();

            //---------------------------------------------------------------------------------

            // Mark

            int mark;
            do
            {
                Console.WriteLine("Enter Mark Of Question : ");
            } while (!int.TryParse(Console.ReadLine(), out mark));
            Mark1 = mark;

            //---------------------------------------------------------------------------------

            // Array Of Answers

            Console.WriteLine("Choices Of Question : ");
            for (int i = 0; i < 3; i++)
            {
                AnswerList[i] = new Answers
                {
                    AnswerId = i + 1
                };
                Console.WriteLine($"Enter Choice Number {i + 1} : ");
                AnswerList[i].AnswerText = Console.ReadLine();
            }

            //---------------------------------------------------------------------------------

            // Right Answer

            int RightAnswerId;
            do
            {
                Console.WriteLine("Enter Id Of Right Answer : ");
            } while (!int.TryParse(Console.ReadLine(), out RightAnswerId));
            RightAnswer.AnswerId = RightAnswerId;
            RightAnswer.AnswerText = AnswerList[RightAnswerId - 1].AnswerText;

            //---------------------------------------------------------------------------------
            Console.Clear();

        } 
        #endregion
    }
}
