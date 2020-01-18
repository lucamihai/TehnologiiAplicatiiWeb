using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var f = new F();
            var g = new G();
            var domi = new List<string>()
            {
                "W1", "W2", "W3", "W4"
            };
            var codomfi = new List<string>()
            {
                "X1", "X2", "X3"
            };
            var codomgi = new List<string>()
            {
                "Y1", "Y2"
            };

            new PushOut().getPushout(f,codomfi,g,codomgi,domi);

            var sr = new Src();
            var tg = new Tgt();
            var A = new List<string>()
            {
                "f","g","h","i","j","k"
            };
            var V = new List<string>()
            {
                "v","w","x","y","z"
            };

            V.Pushout(A, sr, tg).ForEach(Console.WriteLine);
        }
    }
}