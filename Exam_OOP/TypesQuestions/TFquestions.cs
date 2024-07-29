using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using Exam_OOP.MainQuestion;

namespace Exam_OOP.TypesQuestions
{
    internal class TFQuestions : BaseQuestion
    {

 public override string HeaderOfQuestion1 => "True | False Question";

        #region Constructors
        public TFQuestions()
        {
            AnswerList = new Answers[2];
            AnswerList[0] = new Answers(1, "True");
            AnswerList[1] = new Answers(2, "False");
        }
        #endregion

        #region Method
        public override void AddQuestion()
        {
            // Header
            Console.WriteLine(HeaderOfQuestion1);

            // ----------------------------------------------

            // Body

            Console.WriteLine("Enter Body Of Question : ");
            BodyOfQuestion1 = Console.ReadLine();

            // ----------------------------------------------

            // Mark
            int mark;
            do
            {
                Console.WriteLine("Enter Mark Of Question : ");
            } while (!int.TryParse(Console.ReadLine(), out mark));
            Mark1 = mark;

            // ----------------------------------------------

            // Right Answer

            int RightAnswerID;
            do
            {
                Console.WriteLine("Enter ID of Right Answer : ");
            } while (!int.TryParse(Console.ReadLine(), out RightAnswerID));
            RightAnswer.AnswerId = RightAnswerID;
            RightAnswer.AnswerText = AnswerList[RightAnswerID - 1].AnswerText;

            // ----------------------------------------------
            Console.Clear();
        } 
        #endregion
    }
}
