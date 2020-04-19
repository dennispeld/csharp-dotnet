using System;
using System.Collections.Generic;
using System.Text;
using CSHARP.NET.MyObjects;

namespace CSHARP.NET.LocalFunctions
{
    public static class LocalFunctionsStart
    {
        public static void Run()
        {
            List<object> myBooks = new List<object>() {
                new Scrapbook(200, true),
                new Textbook(300),
                new ChildrensBook(400, false),
                new TextNote()
            };

            foreach (object book in myBooks) {
                TestingBooks test = new TestingBooks(book);

                Console.WriteLine(test.Summary);
            }
        }
    }
}
