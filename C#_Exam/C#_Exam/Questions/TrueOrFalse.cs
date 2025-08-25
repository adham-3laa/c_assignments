using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exam
{
    internal class TrueOrFalse : Question
    {
        public TrueOrFalse(string headerOfTheQuestion, string bodyOfTheQuestion, int mark, bool answer)
            : base(headerOfTheQuestion, bodyOfTheQuestion, mark, answer ? new Answer(1, "true") : new Answer(2, "false"))
        {
        }

        public override void ShowQuestion()
        {
            Console.WriteLine(HeaderOfTheQuestion);
            Console.WriteLine(BodyOfTheQuestion);
        }

        public override Answer[] GetAnswers()
        {
            return new Answer[]
            {
                new Answer(1, "True"),
                new Answer(2, "False")
            };
        }
    }
}