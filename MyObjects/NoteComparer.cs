using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CSHARP.NET.MyObjects
{
    public class NoteComparer : IComparer<Note>
    {
        public enum CompareType
        {
            Id,
            Content,
            Type,
            Status
        }

        private CompareType _compareType;

        public NoteComparer(CompareType compareType)
        {
            _compareType = compareType;
        }

        public int Compare(Note x, Note y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;

            return _compareType switch
            {
                CompareType.Id => string.Compare(x.Id, y.Id),
                CompareType.Content => string.Compare(x.Content, y.Content),
                CompareType.Type => x.Type.CompareTo(y.Type),
                CompareType.Status => x.Status.CompareTo(y.Status),
                _ => throw new ArgumentException("Invalid Compare Type"),
            };
        }
    }
}
