using System;

namespace PullBack
{
    public class F : BetterName<String, String>
    {
        public string Compute(string entry)
        {
            switch (entry)
            {
                case "Category1": return "Z1";
                case "Category2": return "Z2";
                case "Category3": return "Z2";
                case "Category4": return "Z3";
                default: throw new ArgumentException();
            }
        }
    }
}
