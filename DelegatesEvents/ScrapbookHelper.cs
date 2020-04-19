using System;
using System.Collections.Generic;
using System.Text;
using CSHARP.NET.MyObjects;

namespace CSHARP.NET.DelegatesEvents
{
    public class ScrapbookHelper
    {
        private readonly MyNotesNotification _notification;

        public List<Note> Notes { get; set; }

        public ScrapbookHelper()
        {
            _notification = new MyNotesNotification();
            Notes = new List<Note>();

            // subscribe to an event
            _notification.OnChanged += Notification_OnChanged;
        }

        private void Notification_OnChanged(string message)
        {
            Console.WriteLine($"{message}");
        }

        public void Add(Note note)
        {
            Notes.Add(note);

            _notification.Notify(note, Action.Added);
        }

        public void Remove(Note note)
        {
            Notes.Remove(note);

            _notification.Notify(note, Action.Removed);
        }
    }
}
