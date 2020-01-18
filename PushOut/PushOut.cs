using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class PushOut : AbstractPushout<string, string>
    {
        public override List<string> getPushout(IFunction<string, string> fi, List<string> codomfi,
            IFunction<string, string> gi, List<string> codomgi, List<string> domi)
        {
            var conections = GetConections(fi, codomfi, gi, codomgi, domi);
            DisplayConections(conections, codomfi, codomgi);
            return null;
        }

        private void DisplayConections(int[,] conections, List<string> codomfi, List<string> codomgi)
        {
            Console.WriteLine("X - down, Y - right");
            Console.Write("  ");
            for (var j = 0; j < codomgi.Count; j++)
            {
                Console.Write($"{codomgi[j]} ");
            }

            Console.WriteLine();
            for (var i = 0; i < codomfi.Count; i++)
            {
                Console.Write($"{codomfi[i]} ");
                for (var j = 0; j < codomgi.Count; j++)
                {
                    Console.Write(conections[i, j] + " ");
                }

                Console.WriteLine();
            }
        }

        private static int[,] GetConections(IFunction<string, string> fi, List<string> codomfi,
            IFunction<string, string> gi, List<string> codomgi, List<string> domi)
        {
            var conections = new int[codomfi.Count, codomgi.Count];

            domi.ForEach(domeniu =>
            {
                var rezX = fi.Calcul(domeniu);
                var rezY = gi.Calcul(domeniu);

                var indexX = codomfi.IndexOf(rezX);
                var indexY = codomgi.IndexOf(rezY);

                indexX = indexX < 0 ? 0 : indexX;
                indexY = indexY < 0 ? 0 : indexY;

                conections[indexX, indexY] = 1;
            });
            return conections;
        }
    }
}