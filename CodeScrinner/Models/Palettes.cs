using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeScrinner.Models
{
    public class Palettes
    {
        public List<string[]> AllPalettes = new List<string[]>();

        public Palettes()
        {
            AllPalettes.Add(new string[] { "rgb(4, 43, 51)", "rgb(50, 82, 88)" });
            AllPalettes.Add(new string[] { "rgb(43, 43, 49)", "rgb(131, 94, 63)" });
            AllPalettes.Add(new string[] { "rgb(227, 139, 188)", "rgb(235, 236, 239)" });
            AllPalettes.Add(new string[] { "rgb(43, 43, 49)", "rgb(116, 2, 13)" });
            AllPalettes.Add(new string[] { "rgb(27, 54, 102)", "rgb(31, 99, 148)" });
            AllPalettes.Add(new string[] { "rgb(20, 199, 197)", "rgb(0, 75, 173)" });
            AllPalettes.Add(new string[] { "rgb(247, 11, 108)", "rgb(247, 110, 17)" });
            AllPalettes.Add(new string[] { "rgb(9, 45, 66)", "rgb(38, 131, 177)" });
            AllPalettes.Add(new string[] { "rgb(90, 20, 8)", "rgb(217, 99, 180)" });
            AllPalettes.Add(new string[] { "rgb(174, 95, 171)", "rgb(95, 58, 148)" });
            AllPalettes.Add(new string[] { "rgb(92, 119, 255)", "rgb(255, 0, 124)" });
            AllPalettes.Add(new string[] { "rgb(69, 69, 69)", "rgb(33, 33, 33)" });
            AllPalettes.Add(new string[] { "rgb(18, 18, 18)", "rgb(24, 24, 24)" });
            //AllPalettes.Add(new string[] { "a", "b" });

        }

    }
}
