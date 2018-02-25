using System;

namespace quiz
{
    class Program
    {
        static void Main(string[] args)
         {
            int answerNumber;
            char answerChar;
            int score = 0;

            Question[] questions = {
                new Question("Most produced tanks during WW2?",
                new string[] {"a. Sherman", "b. T-34", "c. Tiger", "d. Valentine"},
                 'b'),
                new Question("Most produced tanks ever?",
                new string[] {"a. T-55", "b. Leopard", "c. Challenger", "d. Abrams"},
                 'a'),
                new Question("What new infantry fighting vehicles Lithuania ordered in 2016?",
                new string[] {"a. BTR-90", "b. Piranha", "c. Stryker", "d. Boxer"},
                 'd'),
                new Question("How was namd first Lithuania's armored car?",
                new string[] {"a. Šarūnas", "b. Perkūnas", "c. Žaibas", "d. Savanoris"},
                 'c')
            };

            foreach (var question in questions)
            {
                question.printQuestion();
                Console.Write("Answer:");
                answerNumber = Convert.ToChar(Console.ReadLine());
                answerChar = Char.ToLower(Convert.ToChar(answerNumber));
                score = score + question.checkAnswer(answerChar);
            }
            Console.Write("Score: " + score);
        }
    }
    class Question {
        private string question;
        private string[] answers;
        private char answerChar;

        public Question(string question, string[] answers, char answerChar) {
            this.question = question;
            this.answers = answers;
            this.answerChar = answerChar;
        }

        public void printQuestion() {
            Console.WriteLine(question);
            foreach (var answer in answers)
            {
                Console.WriteLine(answer);
            }
        }

        public int checkAnswer(char answer) {
            if (answer.Equals(answerChar)) {
                Console.WriteLine("Correct!");
                return 1;
            } else {
                Console.WriteLine("Incorrect!");
                return 0;
            }
        }
    }
}
