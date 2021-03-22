using System;
using System.Collections.Generic;

namespace ASD_lab5
{
    public static class LinkedListExtensions
    {

        public static void PrintCollectionData<T>(this IEnumerable<T> source)
        {
            foreach (var item in source)
                Console.WriteLine(item);
        }
    }
}