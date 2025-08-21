using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV_Task_4
{
    //a)	Create User Defined Delegate with the same signature of methods existed in Bookfunctions class.
    internal delegate string BookFunctionDelegate(Book book);
    internal class LibraryEngine
    {
        public static void ProcessBooks(List<Book> books, BookFunctionDelegate fptr)
        {
            foreach (var book in books)
            {
                Console.WriteLine(fptr(book));
            }
                        
        }

        //b)	Use the Proper build in delegate. 

        //public static void ProcessBooks(List<Book> books, Func<Book, string> fptr)
        //{
        //    foreach (var book in books)
        //    {
        //        Console.WriteLine(fptr(book));
        //    }
        //}
    }
}
