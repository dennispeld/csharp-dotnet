using System;
using System.Collections.Generic;
using System.Text;

namespace CSHARP.NET.LocalFunctions
{
    internal abstract class Book 
    {
        public int Pages { get; }

        protected Book(int pages)
        {
            Pages = pages;
        }
    }

    internal class Scrapbook : Book
    {
        public bool HasScribbles { get; }

        public Scrapbook(int pages, bool hasScribbles) : base(pages)
        {
            HasScribbles = hasScribbles;
        }
    }

    internal class Textbook : Scrapbook
    {
        public Textbook(int pages) : base(pages, false) { }
    }

    internal class ChildrensBook : Book
    {
        public bool IsClassic { get; }

        public ChildrensBook(int pages, bool isClassic) : base(pages)
        {
            IsClassic = isClassic;
        }
    }

    public class TestingBooks
    {
        public int PagesInTheBook { get; }
        public string Summary { get; }

        public TestingBooks(object bookObject)
        {
            // local function
            static int GetPagesInBook(object book)
            {
                return book switch
                {
                    ChildrensBook childrensBook => childrensBook.Pages,
                    Textbook textbook => textbook.Pages,
                    Scrapbook scrapbook => scrapbook.Pages,
                    _ => 0,
                };
            }

            PagesInTheBook = GetPagesInBook(bookObject);

            Summary = bookObject is Book
                ? $"{bookObject} has {PagesInTheBook} pages"
                : "An object is not a book";
        }
    }
}
