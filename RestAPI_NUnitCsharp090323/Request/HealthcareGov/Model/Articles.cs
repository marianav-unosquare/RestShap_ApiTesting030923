using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI_NUnitCsharp090323.Features.HealthcareGov.NewFolder
{
    internal class Articles
    {
        public List<Article> articles { get; set; }

        public class Article
        {
            public string url { get; set; }
        }
        
    }
}
