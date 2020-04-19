using System;
using System.Collections.Generic;
using System.Text;
using CSHARP.NET.MyObjects;

namespace CSHARP.NET.Collections
{
    /// <summary>
    /// A simple collection of objects of the same type.
    /// You can Add, Remove, Insert, Sort, Find etc.
    /// </summary>
    public static class MyList
    {
        public static List<Note> GetMyList()
        {
            Note[] someMoreNotes = { new ScribbleNote(), new TextNote() };
            
            var myList = InitList();

            // add range elements at the end of the list
            myList.AddRange(someMoreNotes);

            // insert an element to the index 1
            myList.Insert(1, new ScribbleNote());

            // remove an element in the index 0
            myList.RemoveAt(0);

            // sort the list by content
            myList.Sort(new NoteComparer(NoteComparer.CompareType.Content));

            return myList;
        }

        public static List<Note> GetListByNoteType(NoteType type, List<Note> allNotes = null)
        {
            var notes = allNotes ?? GetMyList();

            // sort the list by id
            notes.Sort(new NoteComparer(NoteComparer.CompareType.Id));

            return notes.FindAll(n => n.Type == type);
        }

        public static void Display(List<Note> notes)
        {
            Console.WriteLine("LIST:");
            foreach (Note note in notes) {
                Console.WriteLine(note.ToString("TC"));
            }
            Console.WriteLine();
        }

        public static List<Note> InitList()
        {
            return new List<Note> {
                new PictureNote(),
                new TextNote(),
                new TextNote(),
                new ScribbleNote(),
                new PictureNote(),
                new TextNote(),
                new ScribbleNote(),
                new ScribbleNote()
            };
        }
    }
}
