using System;
using System.Collections.Generic;

namespace Laborator3
{
    public abstract class PushOutAbstract<T1, T2>
    {
        public abstract HashSet<T2> getPushout(functie<T1, T2> fi, HashSet<T2> codomfi,
            functie<T1, T2> gi, HashSet<T2> codomgi, HashSet<T1> domi);
    }
}