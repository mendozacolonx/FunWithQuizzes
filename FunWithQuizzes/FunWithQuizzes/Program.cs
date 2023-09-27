// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using FunWithQuizzes;

Quiz quiz1 = new Quiz();

MultipleChoice mc1 = new MultipleChoice(
    question: "How old is Xiomara? \n 20 \n 23 \n 26",
    answer: "26"
    ); 
quiz1.addQuestion(mc1);

Checkbox cb1 = new Checkbox(
    question: "What color is Xiomara's hair \n Brown \n Blonde \n Red",
    answer: "Brown"
    );
quiz1.addQuestion(cb1);

TrueFalse tf1 = new TrueFalse(
    question: "Xiomara loves coding? \n True or False",
    answer: "True"
    );
quiz1.addQuestion(tf1);

quiz1.runQuiz();