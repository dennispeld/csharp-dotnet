using System;
using System.Collections.Generic;
using System.Text;

namespace CSHARP.NET.RecursivePatterns
{
    public class Book
    {
        public int Pages { get; }
        public string Title { get; }
        public bool Finished { get; set; }
        public bool BloodyLongRead { get => Pages > 400; }

        public Book(int pages, string title, bool finished)
        {
            Pages = pages;
            Title = title;
            Finished = finished;
        }
    }
}
