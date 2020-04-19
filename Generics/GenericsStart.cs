using System;
using System.Collections.Generic;
using System.Text;
using CSHARP.NET.MyObjects;

namespace CSHARP.NET.Generics
{
    public static class GenericsStart
    {
        public static void Run()
        {
            // Add all notes
            var scrapbook = InitScrapbook();

            Console.WriteLine("ALL NOTES:");
            scrapbook.DisplayAllNotes();
            Console.WriteLine();

            // Show only scribble notes
            var scribbleNotes = scrapbook.FindNotesByType(NoteType.Scribble);
            Console.WriteLine("ONLY SCRIBBLE NOTES:");
            scrapbook.DisplayNotes(scribbleNotes);
            Console.WriteLine();

            // Erase first picture note
            var noteToRemove = FindFirstPictureNote(scrapbook);
            scrapbook.Erase(noteToRemove);
            scrapbook.Add(new RemovedNote(noteToRemove));

            // Show only erased notes
            var erasedNotes = scrapbook.FindNotesByStatus(Status.Erased);
            Console.WriteLine("ERASED NOTES:");
            scrapbook.DisplayNotes(erasedNotes);
            Console.WriteLine();

            // Show all notes
            Console.WriteLine("ALL NOTES:");
            scrapbook.DisplayAllNotes();
        }

        private static Scrapbook<Note> InitScrapbook()
        {
            return new Scrapbook<Note> {
                new TextNote(),
                new ScribbleNote(),
                new TextNote(),
                new PictureNote(),
                new ScribbleNote(),
                new TextNote(),
                new TextNote()
            };
        }

        private static Note FindFirstPictureNote(Scrapbook<Note> scrapbook)
        {
            foreach (Note note in scrapbook) {
                if (note.Type == NoteType.Picture)
                    return note;
            }

            return null;
        }
    }
}
