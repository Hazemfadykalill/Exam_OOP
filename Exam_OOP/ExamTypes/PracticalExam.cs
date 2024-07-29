using Exam_OOP.MainQuestion;
using Exam_OOP.TypesQuestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP
{
 class PracticalExam : ShapeExam
    {

        #region Constructors
        public PracticalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions)
        {

        }
        #endregion

        #region Method
        public override void CreateListOfQuestions()
        {
            ListOfQuestions = new MCQQuestion[NumberOfQuestions];
            for (int i = 0; i < ListOfQuestions.Length; i++)
            {
                ListOfQuestions[i] = new MCQQuestion();
                ListOfQuestions[i].AddQuestion();

                Console.Clear();
            }
        }

        public override void ShowExam()
        {
            // Show Question

            foreach (var question in ListOfQuestions)
            {
                Console.WriteLine(question);

                // Answer Of Question
                for (int i = 0; i < question.AnswerList.Length; i++)
                {
                    Console.WriteLine(question.AnswerList[i]);
                }
                Console.WriteLine("----------------------------------------------------------------");

                // User Answer

                int UserAnswerId;
                do
                {
                    Console.WriteLine("Enter ID of Your Answer : ");
                } while (!int.TryParse(Console.ReadLine(), out UserAnswerId));
                question.UserAnswer.AnswerId = UserAnswerId;
                question.UserAnswer.AnswerText = question.AnswerList[UserAnswerId - 1].AnswerText;
                Console.WriteLine("----------------------------------------------------------------");

                // Show Right Answer
                //Console.WriteLine("Right Answer : ");

                for (int i = 0; i < ListOfQuestions.Length; i++)
                {
                    Console.WriteLine($"Question ({i + 1}) : {ListOfQuestions[i].BodyOfQuestion1}");
                    Console.WriteLine($"Right Answer : {ListOfQuestions[i].RightAnswer.AnswerText}");
                    Console.WriteLine("----------------------------------------------------------------");

                }

            }
        } 
        #endregion
    }
}
