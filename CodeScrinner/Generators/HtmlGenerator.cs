using CodeScrinner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CodeScrinner.Generators
{
    public class HtmlGenerator
    {
        private Palettes palettes = new Palettes();
        private BgGenerator bgGenerator = new BgGenerator();
        private BasicHtml basicHtml = new BasicHtml();
        private int paletteNumber = 0;
        Random randomGen = new Random();
        private string BgCss = "";
        private List<int> Angles = new List<int>();
        public HtmlGenerator()
        {
            paletteNumber = palettes.AllPalettes.Count;
            Angles.Add(45);
            Angles.Add(195);
            Angles.Add(225);
            Angles.Add(315);
        }
        public string GenerateHtml(string code)
        {
            randomGen = new Random(DateTime.Now.Minute + DateTime.Now.Millisecond);
            var randPalette = palettes.AllPalettes[randomGen.Next(paletteNumber)];
            var randAngle = Angles[randomGen.Next(Angles.Count)];
            BgCss = bgGenerator.GenerateBg(randPalette, randAngle.ToString());
            string terminalHtml = basicHtml.GenerateBasicHtml(code);
            terminalHtml = terminalHtml.Replace("|BG|", BgCss);
            
            return terminalHtml;
        }
    }
}
