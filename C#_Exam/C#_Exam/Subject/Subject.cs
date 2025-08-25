

namespace C__Exam
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public BaseExam Exam { get; private set; } = null!; // Fix: Initialize with null-forgiving operator

        public Subject(int subjectId, string subjectName)
        {
            if (string.IsNullOrWhiteSpace(subjectName))
            {
                throw new ArgumentException("Subject name cannot be null or empty.");
            }
            if (subjectId <= 0)
            {
                throw new ArgumentException("Subject ID must be a positive integer.");
            }
            SubjectId = subjectId;
            SubjectName = subjectName;
        }

        public void CreateExam()
        {
            string ExamType = TakeTypeOfExam();
            int TimeOfExam = TakeTimeOfExam(ExamType);
            int NumberOfQuestions = NumOfQuestion();

            Question[] questions = new Question[NumberOfQuestions];
            //loop to create questions based on the number of questions specified and using the QuestionBuilder to create each question.
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                questions[i] = QuestionBulider.CreateQuestion(i, ExamType);
            }
            // Create the exam instance based on the type of exam and the questions created.
            Exam = CreateExamInstance(ExamType, TimeOfExam, questions);
        }

        public override string ToString()
        {
            return $"Subject ID: {SubjectId}, Subject Name: {SubjectName}, Exam Type: {Exam.GetType().Name}";
        }

        #region Validation func

        /// TakeTypeOfExam method prompts the user to enter the type of exam and validates the input.
        private string TakeTypeOfExam()
        {
            string? ExamType = null;
            do
            {
                Console.WriteLine("Enter the type of exam (Final/practical): ");
                ExamType = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(ExamType) || ExamType.ToLower() != "final" && ExamType.ToLower() != "practical");
            return ExamType;
        }

        /// TakeTimeOfExam method prompts the user to enter the time of the exam based on the type of exam and validates the input.
        private int TakeTimeOfExam(string ExamType)
        {
            int TimeOfExam;
            if (ExamType.ToLower() == "practical")
            {
                do

                {
                    Console.WriteLine("Enter the time of practical exam in minutes (From 15 To 30): ");
                } while (!int.TryParse(Console.ReadLine(), out TimeOfExam) || TimeOfExam < 15 || TimeOfExam > 30);
                return TimeOfExam;
            }
            else // Final Exam
            {
                do

                {
                    Console.WriteLine("Enter the time of exam in minutes (From 30 to 120): ");
                } while (!int.TryParse(Console.ReadLine(), out TimeOfExam) || TimeOfExam < 30 || TimeOfExam >120);
                return TimeOfExam;
            }
        }

        /// NumOfQuestion method prompts the user to enter the number of questions and validates the input.
        private int NumOfQuestion()
        {
            int NumberOfQuestions;
            do
            {
                Console.WriteLine("Enter the number of questions: ");
            } while (!int.TryParse(Console.ReadLine(), out NumberOfQuestions) || NumberOfQuestions <= 0);
            return NumberOfQuestions;
        }

        #endregion Validation func

        #region create func

        /// CreateExamInstance method creates an instance of the exam based on the type of exam and the questions provided.
        private BaseExam CreateExamInstance(string ExamType, int TimeOfExam, Question[] questions)
        {
            if (ExamType.ToLower() == "final")

            {
                return Exam = new FinalExam(TimeOfExam, questions);
            }
            else
            {
                return Exam = new PracticalExam(TimeOfExam, questions);
            }
        }

        #endregion create func
    }
}