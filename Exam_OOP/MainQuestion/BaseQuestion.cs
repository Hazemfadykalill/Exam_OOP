using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP.MainQuestion
{
   public abstract class BaseQuestion
    {


        #region Constructors
        protected BaseQuestion()
        {
            RightAnswer = new Answers();
            UserAnswer = new Answers();
        }

        #endregion

        #region Property

        public abstract string? HeaderOfQuestion1 { get ; }
        public string? BodyOfQuestion1 { get ; set ; }
        public int Mark1 { get ; set ; }

        public Answers[] AnswerList { get; set; }
        public Answers RightAnswer { get; set; }
        public Answers UserAnswer { get; set; }
        #endregion

        #region Method
        public override string ToString()
        {
            return $"{HeaderOfQuestion1} \t Mark : {Mark1} \n"
                + "------------------------------------" +
                $"\n {BodyOfQuestion1} \n";
        }

        public abstract void AddQuestion();

        #endregion

    }
}
