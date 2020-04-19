using System;
using System.Collections.Generic;
using System.Text;
using CSHARP.NET.MyObjects;

namespace CSHARP.NET.Collections
{
    /// <summary>
    /// Similar to SortedList, but faster i insertion and removal of elements
    /// Nonetheless it uses more memory that SortedList.
    /// </summary>
    public static class MySortedDictionary
    {
        public static SortedDictionary<string, Note> GetMySortedDictionary(List<Note> notes)
        {
            var mySortedDictionary = new SortedDictionary<string, Note>();

            foreach (Note note in notes) {
                mySortedDictionary.Add(note.Id, note);
            }

            return mySortedDictionary;
        }

        public static void Display(List<Note> notes)
        {
            var mySortedDictionary = GetMySortedDictionary(notes);

            Console.WriteLine("SORTED DICTIONARY:");
            foreach (var note in mySortedDictionary.Values) {
                Console.WriteLine($"{note.Id} {note:TC}");
            }
            Console.WriteLine();
        }
    }
}
