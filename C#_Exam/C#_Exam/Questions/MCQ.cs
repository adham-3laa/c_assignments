using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exam
{
    internal class MCQ : Question
    {
        public Answer[] Options { get; }
        public MCQ(string headerOfTheQuestion, string bodyOfTheQuestion, int mark,  int numOfQuestion)
            : base(headerOfTheQuestion, bodyOfTheQuestion, mark)
        {
            
            Options = new Answer[numOfQuestion];
            //loop to take the options from the user and validate the input to ensure it is not empty or null.
            for (int i = 0; i < numOfQuestion; i++)
            {
                string? optionText;   
                do
                {
                    Console.WriteLine($"Enter option {i + 1} text:");
                    optionText = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(optionText));

                Options[i] = new Answer(i + 1, optionText!);
            }
            //take the index of the correct answer from the user and validate the input to ensure it is a valid index.
            int correctAnswerIndex;
            Console.WriteLine("Enter the index of the correct answer:");
            while (!int.TryParse(Console.ReadLine(), out correctAnswerIndex) || correctAnswerIndex < 1 || correctAnswerIndex > numOfQuestion)
            {
                Console.WriteLine($"Invalid input. Please enter a number between 1 and {numOfQuestion}.");
            }
            RightAnswer = Options[correctAnswerIndex - 1];
        }

        public override void ShowQuestion()
        {
            Console.WriteLine( HeaderOfTheQuestion);
            Console.WriteLine(BodyOfTheQuestion);
            foreach (var option in Options)
            {
                Console.WriteLine(option);
            }
            

        }
        // the GetAnswers method returns the options of the question as an array of Answer objects.
        public override Answer[] GetAnswers()
        {
            return Options;
        }
    }
}
