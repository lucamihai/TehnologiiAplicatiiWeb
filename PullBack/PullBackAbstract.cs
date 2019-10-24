using System;
using System.Collections.Generic;

namespace PullBack
{
    public abstract class PullBackAbstract<T1, T2, T3>
    {
        public abstract HashSet<Triple<T1, T2, T3>> getPullback(
            BetterName<T1, T2> fi,
            HashSet<T1> domfi,
            BetterName<T3, T2> gi,
            HashSet<T3> domgi,
            HashSet<T2> codomi,
            Func<T2, T2, bool> comp);
    }
}
