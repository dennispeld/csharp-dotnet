using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using CSHARP.NET.MyObjects;

namespace CSHARP.NET.Generics
{
    public class Scrapbook<T> : IEnumerable<T>
        where T : Note
    {
        private readonly List<T> _scrapbook = new List<T>();

        public void Add(T note)
        {
            _scrapbook.Add(note);
        }

        public void Erase(T note)
        {
            _scrapbook.Remove(note);
        }

        public INote FindNoteById(string id)
        {
            if (_scrapbook.Exists(n => n.Id == id))
                return _scrapbook.Find(n => n.Id == id);

            return null;
        }

        public List<T> FindNotesByType(NoteType type)
        {
            return _scrapbook.FindAll(n => n.Type == type);
        }

        public List<T> FindNotesByStatus(Status status)
        {
            return _scrapbook.FindAll(n => n.Status == status);
        }

        public void DisplayAllNotes()
        {
            foreach (T note in _scrapbook) {

                var outputLine = note.ToString();

                Console.WriteLine(outputLine);
            }
        }

        public void DisplayNotes(List<T> notes)
        {
            foreach (T note in notes) {
                var outputLine = note.ToString();

                Console.WriteLine(outputLine);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)_scrapbook).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
