using CodeScrinner.Properties;
using CodeScrinner.Templates;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CodeScrinner.Models
{
    public class BasicHtml
    {
        private string Title { get; set; }
        private string Body = "";
        AllTemplates allTemplates = new AllTemplates();
        public string GenerateBasicHtml(string code)
        {
            Title = Settings.Default.Title;
            
            
            if (Settings.Default.IsLight)
            {
                Body = allTemplates.AllTmplt[1];
            }
            else
            {
                Body = allTemplates.AllTmplt[0];
            }
                
            

            Body = Body.Replace("|TITLE|", Title);
            Body = Body.Replace("|CONTENT|", code);

            
            return Body;
        }
    }
}
