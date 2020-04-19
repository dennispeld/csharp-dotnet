using System;
using System.Collections.Generic;
using System.Text;
using CSHARP.NET.MyObjects;

namespace CSHARP.NET.Collections
{
    /// <summary>
    /// A stack collection, similar to Queue, but the items put last will be read first (LIFO)
    /// You can Count, Push (add to the top of the stack), Pop (read and remove from the head),
    /// Peek (only read from the head), Contains (check if the item is in the stack)
    /// </summary>
    public static class MyStack
    {
        public static Stack<Note> GetMyStack(List<Note> notes)
        {
            var myStack = new Stack<Note>();

            foreach (Note note in notes) {
                myStack.Push(note);
            }

            return myStack;
        }

        public static void Display(List<Note> notes)
        {
            var myStack = GetMyStack(notes);

            Console.WriteLine("STACK:");
            foreach (Note note in myStack) {
                Console.WriteLine(note.ToString("TC"));
            }

            // read and remove notes from the head of the queue
            myStack.Pop();
            myStack.Pop();
            myStack.Pop();

            Console.WriteLine();
            Console.WriteLine("UPDATED STACK:");
            foreach (Note note in myStack) {
                Console.WriteLine(note.ToString("TC"));
            }
            Console.WriteLine();
        }
    }
}
