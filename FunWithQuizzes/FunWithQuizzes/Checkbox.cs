using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithQuizzes
{
    public class Checkbox : Question
    {
        public Checkbox(string question, string answer) : base (question, answer)
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
