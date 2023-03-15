using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI_NUnitCsharp090323.Request.NasaOpenAPI.Model
{
    public class Asteroids
    {
        public Links links {get;set;}
        public Pages page { get; set; }

        //public List<Links>? links { get; set; }

        public class Links
        {
            public string? next { get; set; }
            public string? self { get; set; }
        }

       // public List<Pages> page { get; set; }
        public class Pages  {
            public int size { get; set; }
            public int number { get; set; }
        }


    }
}
