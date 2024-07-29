using Exam_OOP.TypesQuestions;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP.MainQuestion
{
    public abstract  class ShapeExam
    {
       
        #region Constructors

       public ShapeExam(int timeOfExam, int numberOfQuestions)
        
        {
            TimeOfExam = timeOfExam;
            NumberOfQuestions = numberOfQuestions;
        }


        #endregion

        #region Property
        public int TimeOfExam { get; set ; }
        public int NumberOfQuestions { get; set ; }
        public BaseQuestion[] ListOfQuestions { get; set; }
        #endregion

        #region Method

        // c.Show Exam Functionality that its implementations will be different for each exam based on its type.
        public abstract void ShowExam();
        public abstract void CreateListOfQuestions();
        #endregion


    }
}
