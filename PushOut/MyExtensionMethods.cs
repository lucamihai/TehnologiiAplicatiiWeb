using System.Collections.Generic;

namespace ConsoleApp1
{
    public static class MyExtensionMethods
    {
        public static List<string> Pushout<T1, T2>(this IEnumerable<T2> codomeniu, List<T1> domeniu,
            IFunction<T1, T2> fi, IFunction<T1, T2> gi)
        {
            var connections = new List<string>();
            domeniu.ForEach(domeni =>
            {
                var rezX = fi.Calcul(domeni);
                var rezY = gi.Calcul(domeni);
                
                connections.Add($" {rezX} - {rezY}");
            });
            return connections;
        } 
    }
}