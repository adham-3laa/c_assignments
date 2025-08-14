namespace ADV_Task_3
{
    internal class Program
    {
        #region 1

        //implement a function to reverse the elements of a queue using a stack.Given a Queue,
        private static void ReverseQueue(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>();
            if (queue == null || queue.Count == 0)
            {
                return;
            }
            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }
            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
        }

        #endregion 1

        #region 2

        //2.	Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.
        private static bool IsParentheses(char c)
        {
            return c == '(' || c == '{' || c == '[' || c == ')' || c == '}' || c == ']';
        }
        public static bool IsBalanced(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (!IsParentheses(c))
                {
                    continue;
                }
                else if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')')
                {
                    if (stack.Count == 0 || stack.Pop() != '(')
                        return false;
                }
                else if (c == '}')
                {
                    if (stack.Count == 0 || stack.Pop() != '{')
                        return false;
                }
                else if (c == ']')
                {
                    if (stack.Count == 0 || stack.Pop() != '[')
                        return false;
                }   
        }
            return stack.Count == 0;
        }
        static void PrintIfBalanced(bool isBalanced)
        {
            if (isBalanced)
            {
                Console.WriteLine("The string is balanced.");
            }
            else
            {
                Console.WriteLine("The string is not balanced.");
            }
        }
        #endregion 2


        private static void Main(string[] args)
        {
            #region 1main
            Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5 });
            Console.Write("Original Queue:");
            foreach (var item in queue)
            {
                Console.Write(item + " ");
            }
            ReverseQueue(queue);
            Console.Write( "\nReversed Queue: ");
            foreach (var item in queue)
            {
                Console.Write(item + " ");
            }
            #endregion
            #region 2main
            
            string testString = "{[()]}";
            bool result = IsBalanced(testString);
            Program.PrintIfBalanced(result);
            testString = "{[(])}";
            result = IsBalanced(testString);
            Program.PrintIfBalanced(result);
            testString = "((()))";
            result = IsBalanced(testString);
            Program.PrintIfBalanced(result);
            
            #endregion

        }
    }
}
