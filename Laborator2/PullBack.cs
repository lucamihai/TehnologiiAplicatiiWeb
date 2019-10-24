using System;
using System.Collections.Generic;

namespace Laborator2
{
    public class PullBack : PullBackAbstract<Product, String, Article>
    {
        public override HashSet<Triple<Product, string, Article>> getPullback(
            BetterName<Product, string> fi,
            HashSet<string> domfi,
            BetterName<Article, string> gi,
            HashSet<string> domgi,
            HashSet<string> codomi,
            Func<string, string, bool> comp)
        {
            var results = new HashSet<Triple<Product, String, Article>>();


            if (domfi.Count > domgi.Count)
            {
                foreach (var x in domfi)
                {
                    foreach (var y in domgi)
                    {
                        var rezX = fi.Compute(x);
                        var rezY = gi.Compute(y);
                        if (comp(rezY, rezX))
                        {
                            results.Add(new Triple<Product, string, Article>() {x = x, z = rezY, y = y});
                        }
                    }
                }
            }
            else
            {
                foreach (var y in domgi)
                {
                    foreach (var x in domfi)
                    {
                        var rezX = fi.Compute(x);
                        var rezY = gi.Compute(y);
                        if (comp(rezY, rezX))
                        {
                            results.Add(new Triple<Product, string, Artic>() { x = x, z = rezY, y = y });
                        }
                    }
                }
            }

            return results;
        }
    }
}
