using System;
using System.Collections.Generic;
using System.Text;

namespace CSHARP.NET.Async
{
    public static class AsyncStart
    {
        public static void Run()
        {
            var sharedListing = new ShareService();

            for (int i = 0; i < 100_000_000; i++) {
                _ = sharedListing.GetStockDetails().Result;
            }

            Console.WriteLine($"Garbage collection occured {GC.CollectionCount(0)} times");
            Console.ReadLine();
        }
    }
}
