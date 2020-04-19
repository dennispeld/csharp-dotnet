using System;
using System.Collections.Generic;
using System.Text;
using CSHARP.NET.MyObjects;

namespace CSHARP.NET.Collections
{
    public static class MySortedList
    {
        public static SortedList<string, Note> GetMySortedList(List<Note> notes)
        {
            var mySortedList = new SortedList<string, Note>();

            foreach (Note note in notes) {
                mySortedList.Add(note.Id, note);
            }

            return mySortedList;
        }

        public static void Display(List<Note> notes)
        {
            var mySortedList = GetMySortedList(notes);

            Console.WriteLine("SORTED LIST:");
            foreach (KeyValuePair<string, Note> note in mySortedList) {
                Console.WriteLine($"{note.Key} {note.Value:TC}");
            }
            Console.WriteLine();
        }
    }
}
