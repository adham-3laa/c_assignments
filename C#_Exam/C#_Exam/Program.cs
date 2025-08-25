namespace C__Exam
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Subject subject = new Subject(1, "Mathematics");
            subject.CreateExam();
            Console.WriteLine(subject);
            subject.Exam.ShowExam();
        }
    }
}