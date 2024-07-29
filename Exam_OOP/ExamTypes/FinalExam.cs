using Exam_OOP.MainQuestion;
using Exam_OOP.TypesQuestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP
{
    public class FinalExam : ShapeExam
    {
        #region Attributes

        MCQQuestion? MCQQuestion;
        TFQuestions? TFQuestions; 
        #endregion

        #region Constructors
        public FinalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions)
        { }
        #endregion

        #region Method
        public override void CreateListOfQuestions()
        {
            ListOfQuestions = new BaseQuestion[NumberOfQuestions];

            // For Loop btm4e on list

            for (int i = 0; i < ListOfQuestions.Length; i++)
            {
                int choice;
                do
                {
                    Console.WriteLine("Enter Type Of Question [1 => MCQ || 2 => True & False]");
                } while (!int.TryParse(Console.ReadLine(), out choice) && choice < 1 || choice > 2);

                if (choice == 1)
                {
                    ListOfQuestions[i] = new MCQQuestion();
                    ListOfQuestions[i].AddQuestion();
                }
                else
                {
                    ListOfQuestions[i] = new TFQuestions();
                    ListOfQuestions[i].AddQuestion();
                }
            }
        }

        public override void ShowExam()
        {
            foreach (var questions in ListOfQuestions)
            {
                Console.WriteLine(questions); // Show Questions

                for (int i = 0; i < questions.AnswerList.Length; i++)
                {
                    Console.WriteLine(questions.AnswerList[i]); // Show Answers For Question
                }
                Console.WriteLine("=================================================================");

                int UserAnswerId;
                do
                {
                    Console.WriteLine("Enter Number Of Your Answer : ");
                } while (!int.TryParse(Console.ReadLine(), out UserAnswerId));//Must Input Is Number
                questions.UserAnswer.AnswerId = UserAnswerId;
                questions.UserAnswer.AnswerText = questions.AnswerList[UserAnswerId - 1].AnswerText;

                Console.WriteLine("=================================================================");

                int totalMark = 0, Grade = 0;

                for (int i = 0; i < ListOfQuestions.Length; i++)
                {
                    totalMark += ListOfQuestions[i].Mark1;
                    if (ListOfQuestions[i].RightAnswer.AnswerId == ListOfQuestions[i].UserAnswer.AnswerId)
                    {
                        Grade += ListOfQuestions[i].Mark1;
                    }

                    // Show Question & Answers
                    Console.WriteLine($"Question ({i + 1}) : {ListOfQuestions[i].BodyOfQuestion1}");
                    Console.WriteLine($"Your Answer  : {ListOfQuestions[i].UserAnswer.AnswerText}");
                    Console.WriteLine($"Right Answer : {ListOfQuestions[i].RightAnswer.AnswerText}");
                }

                // Show Grade
                Console.WriteLine($"Your Grade is {Grade} From {totalMark}");

            }
        } 
        #endregion
    }
}
