using System;
using System.Collections.Generic;
using System.Text;

namespace CSHARP.NET.MyObjects
{
    public class RemovedNote: Note
    {
        public RemovedNote(INote note): this(note, $"{note.Content} was removed") { }

        public RemovedNote(INote note, string content): base(content, note.Type, Status.Erased) { }
    }
}
