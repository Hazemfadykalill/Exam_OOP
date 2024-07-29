using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP
{
    public  class Answers
    {

        //(AnswerId, AnswerText).
       
        #region Constructors
        public Answers(int answerId, string? answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }

        public Answers()
        {
                
        }
                    




        #endregion

        #region Property
        public int AnswerId { get; set; }
        public string? AnswerText{ get; set; }

        #endregion

        #region Method
        public override string ToString()
        {
            return  $"{AnswerId} - {AnswerText}"; ;
        }
        #endregion
    }
}
