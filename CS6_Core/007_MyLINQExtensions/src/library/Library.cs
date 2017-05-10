using System;
using System.Collections.Generic;

namespace System.Linq
{
    public static class MyLINQExtensions
    {
        public static IEnumerable<T> ProcessSequence<T>(this IEnumerable<T> sequence)
        {    
            return sequence.Skip(2);
        }

        public static long SumariseSequence<T>(this IEnumerable<T> sequence)
        {
            return sequence.LongCount();
        }
    }
}
