using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exam
{
    internal abstract class Question
    {
        public string HeaderOfTheQuestion { get; set; }
        public string BodyOfTheQuestion { get; set; }
        public int Mark { get; }
        public Answer RightAnswer { get; protected set; }

        protected Question(string headerOfTheQuestion, string bodyOfTheQuestion, int mark, Answer rightAnswer)
        {
            HeaderOfTheQuestion = headerOfTheQuestion;
            BodyOfTheQuestion = bodyOfTheQuestion;
            Mark = mark;
            RightAnswer = rightAnswer ?? throw new ArgumentNullException(nameof(rightAnswer));
        }

        // Overloaded constructor for MCQ because it takes the answer in the constructor of MCQ class after writing the options  
        protected Question(string headerOfTheQuestion, string bodyOfTheQuestion, int mark)
        {
            HeaderOfTheQuestion = headerOfTheQuestion;
            BodyOfTheQuestion = bodyOfTheQuestion;
            Mark = mark;
            RightAnswer = null!; 
        }

        public abstract Answer[] GetAnswers();

        public abstract void ShowQuestion();
    }
}
