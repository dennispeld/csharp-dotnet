using System;
using System.Collections.Generic;
using System.Text;

namespace CSHARP.NET.RecursivePatterns
{
    public static class RecursivePatternsStart
    {
        public static void Run()
        {
            List<Book> myBooks = new List<Book>() {
                new Book(356, "The beach", true),
                new Book(341, "The invisibles", false),
                new Book(945, "Shantaram", false),
                new Book(412, "The fifth child", true)
            };

            foreach (var book in myBooks) {
                // using recursive pattern to show the message only to books that have been finished
                if (book is Book { Finished: true }) {
                    Console.WriteLine($"The book \"{book.Title}\" has been finished.");
                }

                if (book is Book { BloodyLongRead: true }) {
                    Console.WriteLine($"The book \"{book.Title}\" is very long and has {book.Pages} pages.");
                }
                else {
                    Console.WriteLine($"The book \"{book.Title}\" is very short and has only {book.Pages} pages.");
                }
            }
        }
    }
}
