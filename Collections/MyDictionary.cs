using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using CSHARP.NET.MyObjects;

namespace CSHARP.NET.Collections
{
    /// <summary>
    /// Dictionary (or Hash table, or Map) is a collection that you can access an element by key
    /// </summary>
    public static class MyDictionary
    {
        public static Dictionary<string, Note> GetMyDictionary(List<Note> notes)
        {
            var myDictionary = new Dictionary<string, Note>();

            foreach (Note note in notes) {
                myDictionary.Add(note.Id, note);
            }

            return myDictionary;
        }

        public static void Display(List<Note> notes)
        {
            var myDictionary = GetMyDictionary(notes);

            Console.WriteLine("DICTIONARY:");
            foreach (var note in myDictionary.Values) {
                Console.WriteLine($"{note.Id} {note:TC}");
            }
            Console.WriteLine();
        }
    }
}
