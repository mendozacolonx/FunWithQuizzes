using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithQuizzes
{
    //abstract?
    public abstract class Question
    {
        //class variables
        //question string
        //answer

        //
        private string aQuestion;

        private string anAnswer;

        //constructors
        public Question(string question, string answer)
        {
            this.aQuestion = question;
            this.anAnswer = answer;
        }

        //methods + getters
        public string getQuestion() { return this.aQuestion; }
        public string getAnswer() { return this.anAnswer; }

        //method to check the answer
        public abstract bool checkAnswer(string answer);
    }
}
