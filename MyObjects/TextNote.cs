using System;
using System.Collections.Generic;
using System.Text;
using CSHARP.NET.Helpers;

namespace CSHARP.NET.MyObjects
{
    public class TextNote: Note
    {
        public TextNote(): this(string.Empty.Random(10)) { }

        public TextNote(string content): base(content, NoteType.Text, Status.Existing) { }
    }
}
