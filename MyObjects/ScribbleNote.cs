using System;
using System.Collections.Generic;
using System.Text;
using CSHARP.NET.Helpers;

namespace CSHARP.NET.MyObjects
{
    public class ScribbleNote: Note
    {
        public ScribbleNote(): this(string.Empty.Random(10)) { }

        public ScribbleNote(string content): base(content, NoteType.Scribble, Status.Existing) { }
    }
}
