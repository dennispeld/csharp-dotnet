using System;
using System.Collections.Generic;
using System.Text;

namespace CSHARP.NET.MyObjects
{
    public enum NoteType
    {
        Text,
        Scribble,
        Picture
    }

    public enum Status
    {
        Existing,
        Erased
    }

    public class Note: INote, IComparable<Note>, IFormattable
    {
        public string Id { get; set; }
        public string Content { get; set; }
        public NoteType Type { get; set; }
        public Status Status { get; set; }

        public Note(string content, NoteType type, Status status)
        {
            Id = Guid.NewGuid().ToString();
            Content = content;
            Type = type;
            Status = status;
        }

        public override string ToString() => $"{Type} {Content} ({Id})";

        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (format == null) format = "N";

            return (format.ToUpper()) switch
            {
                "N" => ToString(),
                "T" => Type.ToString(),
                "C" => Content,
                "TC" => $"{Type} {Content}",
                "I" => Id,
                "S" => Status.ToString(),
                _ => throw new FormatException(String.Format(formatProvider, $"Format {format} is not supported.")),
            };
        }

        public string ToString(string format) => ToString(format, null);

        public int CompareTo(Note other)
        {
            int compare = Type.CompareTo(other?.Type);

            if (compare == 0) {
                return Id?.CompareTo(other?.Id) ?? -1;
            }

            return compare;
        }
    }
}
