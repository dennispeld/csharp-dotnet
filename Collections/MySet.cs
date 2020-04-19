using System;
using System.Collections.Generic;
using System.Text;
using CSHARP.NET.MyObjects;

namespace CSHARP.NET.Collections
{
    /// <summary>
    /// Sets are used to contain only distinct items. 
    /// HashSet contains unordered items, SortSet contains ordered items.
    /// </summary>
    public static class MySet
    {
        public static HashSet<Note> GetMySet(List<Note> notes)
        {
            // HashSet
            var mySet = new HashSet<Note>();

            foreach (Note note in notes) {
                mySet.Add(note);
            }

            return mySet;
        }

        public static void Display(List<Note> notes)
        {
            var mySet = GetMySet(notes);

            Console.WriteLine("SET:");
            foreach (Note note in mySet) {
                Console.WriteLine(note.ToString("TC"));
            }

            // other set with one of the notes that already exists in the original set
            var otherSet = new HashSet<Note>() { notes[0], new PictureNote() };

            Console.WriteLine();
            if (mySet.Overlaps(otherSet)) {
                Console.WriteLine("At least one note exist in both sets");
            }

            foreach (Note note in otherSet) {
                if (!mySet.Add(note)) {
                    Console.WriteLine($"{note:TC} is already in the set");
                }
            }
            Console.WriteLine();

            // SortedSet
            var mySortedSet = new SortedSet<Note>();
            foreach (Note note in mySet) {
                mySortedSet.Add(note);
            }

            Console.WriteLine("UPDATED AND SORTED SET:");
            foreach (Note note in mySortedSet.Reverse()) {
                Console.WriteLine(note.ToString("TC"));
            }
        }
    }
}
