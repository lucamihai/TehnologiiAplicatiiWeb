using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator2
{
    class G: BetterName<String,String>
    {
        public string Compute(string entry)
        {
            switch (entry)
            {
                case "Category1": return "Z1";
                case "Category2": return "Z2";
                case "Category3": return "Z4";
                case "Category4": return "Z2";
                default: throw new ArgumentException();
            }
        }
    }
}
