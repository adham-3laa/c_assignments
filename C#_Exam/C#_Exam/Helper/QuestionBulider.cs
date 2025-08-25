using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C__Exam
{
    // this class is responsible for creating questions based on the exam type and index.
    internal static class QuestionBulider
    { 
        
        public static Question CreateQuestion(int index,string ExamType)
        {
            
            string? QuestionType = TakeQuestionType(ExamType, index);
            // this variable is used to store the header of the question based on the type of question.
            string HeaderOfTheQuestion = QuestionType.ToLower() == "mcq" ? "MCQ Question" : "True or False Question";
            string BodyOfTheQuestion = TakeBodyOfTheQuestion(index);

            int Mark = TakeMark(index);
            // this switch statement is used to create the question based on the type of question and return it.
            if (QuestionType.ToLower() == "mcq") return  CreateMcqQuestion(index, HeaderOfTheQuestion, BodyOfTheQuestion, Mark);
            else return  CreateTrueOrFalseQuestion(index, HeaderOfTheQuestion, BodyOfTheQuestion, Mark);
           
        }
        // this method creates a multiple-choice question with the specified parameters.
        private static Question CreateMcqQuestion(int i, string HeaderOfTheQuestion, string BodyOfTheQuestion, int Mark)
        {
            int NumberOfOptions;
            do
            {
                Console.WriteLine($"Enter the number of options for question {i + 1} at lest 2 options: ");
            } while (!int.TryParse(Console.ReadLine(), out NumberOfOptions) || NumberOfOptions < 2);
            return new MCQ(HeaderOfTheQuestion, BodyOfTheQuestion, Mark, NumberOfOptions);
        }
        // this method creates a true or false question with the specified parameters.
        private static Question CreateTrueOrFalseQuestion(int i, string HeaderOfTheQuestion, string BodyOfTheQuestion, int Mark)
        {
            string AnswerText = AnswerOFTF();
            bool Answer = AnswerText.ToLower() == "true";

            return new TrueOrFalse(HeaderOfTheQuestion, BodyOfTheQuestion, Mark, Answer);
        }
        // this method takes the type of question from the user based on the exam type and validates the input to ensure it is either "MCQ" or "TF" for final exams, or defaults to "MCQ" for practical exams.
        private static string TakeQuestionType(string ExamType, int i)
        {
            string? QuestionType = null;
            do
            {
                if (ExamType.ToLower() == "final")
                {
                    Console.WriteLine($"Enter the type of question {i + 1}  (MCQ/TF): ");
                    QuestionType = Console.ReadLine();
                }
                //the else part is used to set the question type to "MCQ" for practical exams.
                else QuestionType = "mcq";
            } while (string.IsNullOrWhiteSpace(QuestionType) || QuestionType.ToLower() != "mcq" && QuestionType.ToLower() != "tf");
            return QuestionType;
        }
        // this method takes the body of the question from the user and validates the input to ensure it is not empty or null.
        private static string TakeBodyOfTheQuestion(int i)
        {
            Console.WriteLine($"Enter the body of the question {i + 1}: ");
            string? BodyOfTheQuestion = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(BodyOfTheQuestion))
            {
                Console.WriteLine("Body cannot be empty. Please enter the body of the question again: ");
                BodyOfTheQuestion = Console.ReadLine();
            }
            return BodyOfTheQuestion;
        }
        // this method takes the mark for the question from the user and validates the input to ensure it is a positive integer.
        private static int TakeMark(int i)
        {
            int Mark;
            do
            {
                Console.WriteLine($"Enter the mark for question {i + 1}: ");
            } while (!int.TryParse(Console.ReadLine(), out Mark) || Mark <= 0);
            return Mark;
        }
        // this method takes the answer for the true or false question from the user and validates the input to ensure it is either "true" or "false".
        private static string AnswerOFTF()
        {
            string? AnswerText;
            do
            {
                Console.WriteLine($"Enter the answer for the question  (True/False): ");
                AnswerText = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(AnswerText) || AnswerText.ToLower() != "true" && AnswerText.ToLower() != "false");
            return AnswerText.ToLower();
        }

    }
}
