using System;
using System.Collections.Generic;
using System.Text;
using CSHARP.NET.Helpers;
using CSHARP.NET.MyObjects;

namespace CSHARP.NET.Collections
{
    /// <summary>
    /// Linked lists are fast, because each element knows about the previous and the next elements.
    /// </summary>
    public static class MyLinkedList
    {
        public static LinkedList<Note> GetMyLinkedList(List<Note> notes)
        {
            var myLinkedList = new LinkedList<Note>();

            foreach (Note note in notes) {
                myLinkedList.AddLast(note);
            }

            // delete the last note
            var lastNote = myLinkedList.Last.Value;
            myLinkedList.RemoveLast();

            // add deleted note to the beginning of the list
            myLinkedList.AddFirst(new RemovedNote(lastNote));

            return myLinkedList;
        }

        public static void Display(List<Note> notes)
        {
            var myLinkedList = GetMyLinkedList(notes);

            Console.WriteLine("LINKED LIST:");
            foreach (var note in myLinkedList) {
                Console.WriteLine($"{note:TC}");
            }
            Console.WriteLine();
        }
    }
}
