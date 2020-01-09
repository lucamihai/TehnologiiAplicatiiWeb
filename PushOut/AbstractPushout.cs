using System.Collections.Generic;

namespace ConsoleApp1
{
    public abstract class AbstractPushout<T1, T2>
    {
        public abstract List<T2> getPushout(
            IFunction<T1, T2> fi,
            List<T2> codomfi,
            IFunction<T1, T2> gi,
            List<T2> codomgi,
            List<T1> domi);
    }
}