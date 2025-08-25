
namespace C__Exam
{
    internal class FinalExam : BaseExam
    {
        public FinalExam(int timeOfExam, Question[] questions) : base(timeOfExam, questions)
        {
        }

        public override void ShowExam()
        {
            StartTime = DateTime.Now;
            EndTime = StartTime.AddMinutes(TimeOfExam);
            Console.WriteLine($"Final Exam started at {StartTime} and will end at {EndTime}");
            Console.WriteLine($"Number of Questions: {NumberOfQuestions}");
            int grades = 0;
            for (int i = 0; i < questions.Length; i++)
            {
                if (DateTime.Now > EndTime)
                {
                    Console.WriteLine("Time is up! Exam ended.");
                    break;
                }
                questions[i].ShowQuestion();
                int answerId = TakeAnswerId(questions[i]);

                Answer? selectedAnswer = FindAnswer(questions[i].GetAnswers(), answerId);
                if (selectedAnswer != null)
                {
                    StudentAnswers[i] = selectedAnswer;
                    if (StudentAnswers[i].Id == questions[i].RightAnswer.Id)
                    {
                        grades += questions[i].Mark;
                    }
                }
            }
            EndOfExam(grades);
        }

        #region Helper func
        // This method is used to end the exam and display the results, including the questions, answers, total marks, time spent, and time information.
        private void EndOfExam(int grades)
        {
            Console.WriteLine("------------------------------");
            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine($"Question {i + 1}: {questions[i].BodyOfTheQuestion}");
                Console.WriteLine($"Your Answer: {StudentAnswers[i].Text}");
                Console.WriteLine($"Correct Answer: {questions[i].RightAnswer.Text }");
                Console.WriteLine("------------------------------");
            }
            Console.WriteLine($"Total Marks: {grades}");
            Console.WriteLine($"Spent Time: {DateTime.Now - StartTime}");
            Console.WriteLine($"Exam ended at {DateTime.Now}. You have {EndTime - DateTime.Now} left.");
        }

        #endregion Helper func
    }
}