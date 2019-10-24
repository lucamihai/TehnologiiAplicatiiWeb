using System;
using System.Collections.Generic;

namespace Laborator3
{
    public static class MyExtensionMethods
    {
        public static HashSet<T2> Pushout<T1, T2>(this IEnumerable<T2> codomeniu,
            HashSet<T1> domeniu, functie<T1, T2> fi, functie<T1, T2> gi)
        {
            throw new NotImplementedException();
        }
    }
}