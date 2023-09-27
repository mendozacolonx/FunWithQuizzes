using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithQuizzes
{
    public class Quiz
    {
        //class variables
        private ArrayList questions = new ArrayList();
        private int numOfQuestionsCorrect = 0;

        //constructors
        public Quiz() { }

        //methods
        public void addQuestion(Question question)
        {
            this.questions.Add(question);
        }

        public void runQuiz()
        {
            //loop through each question
            foreach(Question question in questions)
            {
                //ask the user questions
                Console.WriteLine(question.getQuestion());

                //get the user answer
                string userAnswer = Console.ReadLine();
                //check the answer
                Boolean userAnswerRight = question.checkAnswer(userAnswer);

                if (userAnswerRight)
                {
                    this.numOfQuestionsCorrect++;
                }
            }

            //grade the quiz
            double precentCorrect = (this.numOfQuestionsCorrect / this.questions.Count ) *100;
            Console.WriteLine("Grade: " + precentCorrect + "%");
        }

    }
}
