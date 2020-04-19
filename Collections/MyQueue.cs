using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CSHARP.NET.MyObjects;

namespace CSHARP.NET.Collections
{
    /// <summary>
    /// A queue collection, the items put first will be read first (FIFO)
    /// You can Count, Enqueue (add to the end of the queue), Dequeue (read and remove from the head),
    /// Peek (only read from the head), TrimExcess (resize the capacity of the queue if an item is removed)
    /// </summary>
    public static class MyQueue
    {
        public static Queue<Note> GetMyQueue(List<Note> notes)
        {
            var myQueue = new Queue<Note>();

            foreach (Note note in notes) {
                myQueue.Enqueue(note);
            }

            return myQueue;
        }

        public static void Display(List<Note> notes)
        {
            var myQueue = GetMyQueue(notes);

            Console.WriteLine("QUEUE:");
            foreach (Note note in myQueue) {
                Console.WriteLine(note.ToString("TC"));
            }

            // read and remove notes from the head of the queue
            myQueue.Dequeue();
            myQueue.Dequeue();
            myQueue.Dequeue();

            Console.WriteLine();
            Console.WriteLine("UPDATED QUEUE:");
            foreach (Note note in myQueue) {
                Console.WriteLine(note.ToString("TC"));
            }
            Console.WriteLine();
        }
    }
}
