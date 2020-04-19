using System;

namespace CSHARP.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            // GENERICS
            Generics.GenericsStart.Run();

            // COLLECTIONS
            Collections.CollectionsStart.Run();

            // DELEGATES AND EVENTS
            DelegatesEvents.DelegatesEventsStart.Run();

            // TUPLES
            Tuples.TuplesStart.Run();

            // LOCAL FUNCTIONS
            LocalFunctions.LocalFunctionsStart.Run();

            // ASYNCHRONOUS PROGRAMMING 
            // (its a long process, that's why it is commented out)
            //Async.AsyncStart.Run();

            // RECURSIVE PATTERNS
            RecursivePatterns.RecursivePatternsStart.Run();
        }
    }
}
