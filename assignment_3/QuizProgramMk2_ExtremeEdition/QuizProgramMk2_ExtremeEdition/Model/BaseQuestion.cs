using System;
using System.Collections.Generic;
using System.Text;

namespace QuizProgramMk2_ExtremeEdition.Model
{
    class BaseQuestion
    {
        protected string Question { get; set; }
        
        protected List<Answer> myAnswers = new List<Answer>();

        public List<Answer> GetAnswers()
        {
            return myAnswers;
        }
        public void AddAnswer(string answer,bool taco)
        {
            Answer temp = new Answer();
            temp.MyAnswer = answer;
            temp.isCorrect = taco;
            myAnswers.Add(temp);
        }

    }
}
