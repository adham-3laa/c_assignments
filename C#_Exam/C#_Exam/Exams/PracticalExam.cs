

namespace C__Exam

{
    internal class PracticalExam : BaseExam
    {
        public PracticalExam(int timeOfExam, Question[] questions) : base(timeOfExam, questions)
        {
        }
        // ShowExam is used to start the practical exam, display the questions, take answers from the user, and calculate the grades based on the answers provided.
        public override void ShowExam()
        { // display the start time and end time of the exam.
            StartTime = DateTime.Now;
            EndTime = StartTime.AddMinutes(TimeOfExam);
            Console.WriteLine($"Practical Exam started at {StartTime} and will end at {EndTime}");
            Console.WriteLine($"Number of Questions: {NumberOfQuestions}");
            int grades = 0;
            // the loop checks if the current time is greater than the end time of the exam, if so, it breaks the loop and ends the exam.
            for (int i = 0; i < questions.Length; i++)
            {
                if (DateTime.Now > EndTime)
                {
                    Console.WriteLine("Time is up! Exam ended.");
                    break;
                }
                questions[i].ShowQuestion();
                int answerId = TakeAnswerId(questions[i]);
                // This line finds the answer by its id in the answers array of the question and adds it to the StudentAnswers array and calculates the grades based on the answers provided.
                Answer? selectedAnswer = FindAnswer(questions[i].GetAnswers(), answerId);
                if (selectedAnswer != null)
                {
                    StudentAnswers[i] = selectedAnswer;
                    // If the selected answer's id matches the right answer's id, it adds the question's mark to the grades.
                    if (StudentAnswers[i].Id == questions[i].RightAnswer.Id)
                    {
                        grades += questions[i].Mark;
                    }
                }
            }
            EndExam(grades);
        }

        #region Helper func
        // This method is used to end the exam and display the results, including the questions, answers, total marks, time spent, and time information.
        private void EndExam(int grades)
        {
            Console.WriteLine("------------------------------");
            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine($"Question {i + 1}: {questions[i].BodyOfTheQuestion}");
                Console.WriteLine($"Your Answer: {StudentAnswers[i].Text}");
                Console.WriteLine($"Correct Answer: {questions[i].RightAnswer.Text}");
                Console.WriteLine("------------------------------");
            }
            Console.WriteLine($"Total Marks: {grades}");
            Console.WriteLine($"Spent Time: {DateTime.Now - StartTime}");
            Console.WriteLine($"Exam ended at {DateTime.Now}. You have {EndTime - DateTime.Now} left.");
        }

        #endregion Helper func
    }
}