using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeScrinner.Generators
{
    public class BgGenerator
    {
        public BgGenerator()
        {

        }
        public String GenerateBg(string[] palette, string angle)
        {
            string Css = "background: -webkit-linear-gradient(" + angle + "deg, " + palette[0] + ", " + palette[1] + ");background: -moz-linear-gradient(" + angle + "deg, " + palette[0] + ", " + palette[1] + ");background: linear-gradient(" + angle + "deg, " + palette[0] + ", " + palette[1] + ");";
            return Css;
        }
    }
}
