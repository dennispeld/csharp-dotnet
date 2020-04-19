using System;
using System.Collections.Generic;
using System.Text;
using CSHARP.NET.MyObjects;

namespace CSHARP.NET.Tuples
{
    /// <summary>
    /// Tuples are used to return multiple variables
    /// </summary>
    public class MyTuple
    {
        // Tuple-returning function
        public (NoteType, string) GetNote()
        {
            return (NoteType.Scribble, "Scribble text from Tuple");
        }

        // Tuple-returning function with member names for return types
        public (NoteType TypeOfNote, string Message) GetNoteWithTupleMemberNames()
        {
            return (NoteType.Picture, "Picture text from Tuple");
        }

        // pass tuples as parameters
        public void WriteToScrapbook((NoteType TypeOfNote, string Message) newNote)
        {
            Console.WriteLine($"{newNote.TypeOfNote} {newNote.Message}");
        }
    }
}
