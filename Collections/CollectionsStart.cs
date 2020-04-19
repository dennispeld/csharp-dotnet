using System;
using System.Collections.Generic;
using System.Text;
using CSHARP.NET.MyObjects;

namespace CSHARP.NET.Collections
{
    /// <summary>
    /// Sorted lists are key-value collections that you can sort by key.
    /// </summary>
    public static class CollectionsStart
    {
        public static void Run()
        {
            // we will reuse the list of notes
            var myNotes = MyList.GetMyList();

            MyList.Display(myNotes);
            
            MyQueue.Display(myNotes);

            MyStack.Display(myNotes);

            MyLinkedList.Display(myNotes);

            MySortedList.Display(myNotes);

            MyDictionary.Display(myNotes);

            MySortedDictionary.Display(myNotes);

            MySet.Display(myNotes);
        }
    }
}
