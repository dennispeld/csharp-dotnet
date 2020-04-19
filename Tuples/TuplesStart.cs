using System;
using System.Collections.Generic;
using System.Text;
using CSHARP.NET.MyObjects;

namespace CSHARP.NET.Tuples
{
    public static class TuplesStart
    {
        public static void Run()
        {
            MyTuple myTuple = new MyTuple();
            
            ReadAndDisplayTuple(myTuple);

            ReadAndDisplayTupleWithMembersNames(myTuple);

            ReadAndDisplayTupleWithMembersNamesOverriden(myTuple);

            PassTupleAsParameter(myTuple);
        }

        private static void ReadAndDisplayTuple(MyTuple myTuple)
        {
            var noteFromTuple = myTuple.GetNote();

            Console.WriteLine(noteFromTuple.Item1);
            Console.WriteLine(noteFromTuple.Item2);
        }

        private static void ReadAndDisplayTupleWithMembersNames(MyTuple myTuple)
        {
            var noteFromTuple = myTuple.GetNoteWithTupleMemberNames();

            Console.WriteLine(noteFromTuple.TypeOfNote);
            Console.WriteLine(noteFromTuple.Message);
        }

        private static void ReadAndDisplayTupleWithMembersNamesOverriden(MyTuple myTuple)
        {
            // to take a tuple and split into parameters is called Tuple Deconstruction
            // this is an EXPLICIT deconstruction
            (NoteType Type, string SimpleMessage) noteFromTuple = myTuple.GetNoteWithTupleMemberNames();
            Console.WriteLine(noteFromTuple.Type);
            Console.WriteLine(noteFromTuple.SimpleMessage);

            // or without a local variable
            // you can replace the type with var to any of the parameters
            // this is an INDIVIDUAL inferring deconstruction
            (NoteType Type, var SimpleMessage) = myTuple.GetNoteWithTupleMemberNames();
            Console.WriteLine(Type);
            Console.WriteLine(SimpleMessage);

            // or even implicitly typed variables (including var)
            // this is an INFERRING deconstruction
            var (NewType, NewSimpleMessage) = myTuple.GetNoteWithTupleMemberNames();
            Console.WriteLine(NewType);
            Console.WriteLine(NewSimpleMessage);

            // or decontruct into PREVIOUSLY DECLARED VARIABLES
            NoteType NType;
            string NMessage = "";
            (NType, NMessage) = myTuple.GetNoteWithTupleMemberNames();
            Console.WriteLine(NType);
            Console.WriteLine(NMessage);
        }

        private static void PassTupleAsParameter(MyTuple myTuple)
        {
            NoteType myNoteType = NoteType.Scribble;
            string message = "A message passed via tuple as parameter";

            var note = (myNoteType, message);
            myTuple.WriteToScrapbook(note);
        }
    }
}
