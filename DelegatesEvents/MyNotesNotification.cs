using System;
using System.Collections.Generic;
using System.Text;
using CSHARP.NET.MyObjects;

namespace CSHARP.NET.DelegatesEvents
{
    public enum Action
    {
        Added = 0,
        Removed = 1
    }
    public class MyNotesNotification
    {
        // declare a delegate that will pass the message and an action
        public delegate void ScrapbookUpdate(string message);

        // declare an event OnChange of a delegate type
        public event ScrapbookUpdate OnChanged;

        public void Notify(Note note, Action action)
        {
            OnChanged?.Invoke($"Scrapbook update. {note:TC} was {action.ToString().ToUpper()}.");
        }
    }
}
