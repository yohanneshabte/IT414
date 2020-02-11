using System;
using System.Collections.Generic;
using System.Text;
using QuizProgramMk2_ExtremeEdition.Model;

namespace QuizProgramMk2_ExtremeEdition.Controller
{
    class Quiz
    {
        private List<BaseQuestion> MyQuestions = new List<BaseQuestion>();

        public void AddQuestion(BaseQuestion question)
        {
            MyQuestions.Add(question)
        }



    }
}
