using System;
using System.Collections.Generic;
using System.Text;
using CSHARP.NET.MyObjects;

namespace CSHARP.NET.DelegatesEvents
{
    public static class DelegatesEventsStart
    {
        public static void Run()
        {
            ScrapbookHelper scrapbookHelper = new ScrapbookHelper();

            var tempoNote = new TextNote("DRAFT");

            scrapbookHelper.Add(new PictureNote());
            scrapbookHelper.Add(tempoNote);
            scrapbookHelper.Add(new TextNote());
            scrapbookHelper.Add(new ScribbleNote());
            scrapbookHelper.Remove(tempoNote);

            Console.WriteLine();
            Console.WriteLine("FINAL LIST:");
            foreach(Note note in scrapbookHelper.Notes) {
                Console.WriteLine($"{note:TC}");
            }
        }
    }
}
