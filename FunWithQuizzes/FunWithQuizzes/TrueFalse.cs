using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace FunWithQuizzes
{
    //   Class name
    public class TrueFalse : Question
    {
        //Fields and properties with access modifiers

        //Methods with access modifiers

        //Any inheritance relationship

        public TrueFalse(string question, string answer) : base (question, answer)
        {

        }
        public override bool checkAnswer(string answer)
        {
            //answer is true or false, or TRUE or FALSE

            if (answer.ToUpper().Equals(this.getAnswer().ToUpper()))
            {
                return true;
            }
            else 
            {
                return false;
            }

        }

    }
}
