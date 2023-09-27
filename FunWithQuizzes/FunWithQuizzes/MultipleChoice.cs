using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace FunWithQuizzes
{
//    Class name
//Fields and properties with access modifiers
//Methods with access modifiers
//Any inheritance relationship
    public class MultipleChoice : Question
    {
        public MultipleChoice (string question, string answer) : base(question, answer)

        {
        }
        public override bool checkAnswer(string answer)
        {
            //answer is a string. need to compare it to the actual answer
            string actualAnswer = this.getAnswer();
            if (actualAnswer.ToUpper() != answer.ToUpper())
            {
                return false;
            }
            else
            {
                return true;

            }
        }
    }
}
