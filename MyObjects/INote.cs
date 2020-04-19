using System;
using System.Collections.Generic;
using System.Text;

namespace CSHARP.NET.MyObjects
{
    public interface INote
    {
        public string Id { get; set; }
        public string Content { get; set; }
        public NoteType Type { get; set; }
        public Status Status { get; set; }
    }
}
