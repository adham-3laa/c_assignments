using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exam

{
    //we made it abstract because we don't want to create an object from it directly.
    internal abstract class BaseExam
    {
        public int TimeOfExam { get; set; }
        public int NumberOfQuestions { get; set; }
        public Answer[] StudentAnswers { get; protected set; }
        public Question[] questions { get; set; }

        // StartTime and EndTime are used to track the exam duration to make the exam end if the time is up.
        protected DateTime StartTime { get; set; }

        protected DateTime EndTime { get; set; }

        protected BaseExam(int timeOfExam, Question[] questions)
        {
            if (timeOfExam > 0)
                TimeOfExam = timeOfExam;
            else

                throw new ArgumentException("Time of exam cannot be negative.");
            if (questions != null && questions.Length > 0)
                this.questions = questions;
            else
                throw new ArgumentException("Number of questions must be greater than zero.");
            NumberOfQuestions = questions.Length;

            StudentAnswers = new Answer[NumberOfQuestions];
        }

        public abstract void ShowExam();

        // This method is used to find the answer by its id in the answers array of the question.
        protected Answer? FindAnswer(Answer[] answers, int id)
        {
            for (int i = 0; i < answers.Length; i++)
            {
                if (answers[i].Id == id)
                    return answers[i];
            }
            return null;
        }

        // This method is used to take the answer id from the user based on the question type and validate the input and ensure it is within the valid range of options for that question type.
        protected int TakeAnswerId(Question question)
        {
            int answerId;
            if (question is MCQ mcq)
            {
                Console.WriteLine("Please enter your answer id:");
                while (!int.TryParse(Console.ReadLine(), out answerId) || answerId < 1 || answerId > mcq.Options.Length)
                {
                    Console.WriteLine($"Invalid input. Please enter a number between 1 and {mcq.Options.Length}.");
                }
            }
            else if (question is TrueOrFalse)
            {
                Console.WriteLine("Please enter your answer id (1 for True, 2 for False):");
                while (!int.TryParse(Console.ReadLine(), out answerId) || answerId < 1 || answerId > 2)
                {
                    Console.WriteLine("Invalid input. Please enter 1 for True or 2 for False.");
                }
            }
            else
            {
                throw new ArgumentException("Unknown question type.");
            }

            return answerId;
        }
    }
}