using System;
using System.Collections.Generic;
using System.Text;
using CSHARP.NET.Helpers;

namespace CSHARP.NET.MyObjects
{
    public class PictureNote: Note
    {
        public PictureNote(): this(string.Empty.Random(10)) { }

        public PictureNote(string content): base(content, NoteType.Picture, Status.Existing) { }
    }
}
