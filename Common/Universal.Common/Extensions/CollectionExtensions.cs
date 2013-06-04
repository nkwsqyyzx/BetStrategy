using System;
using System.Collections.Generic;

namespace WSQ.CSharp.Extensions
{
    public static class CollectionExtensions
    {
        public static void Enumerate<T>(this IEnumerable<T> items, Predicate<T> predicate, Action<T> excute)
        {
            foreach (var i in items)
            {
                if (predicate(i))
                {
                    excute(i);
                }
            }
        }

        public static void Enumerate<T>(this IEnumerable<T> items, Action<T> excute)
        {
            foreach (var i in items)
            {
                excute(i);
            }
        }
    }
}
