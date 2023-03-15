using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI_NUnitCsharp090323.Features.NasaOpenAPI
{
    public class PlaceDetailsResponse
    {
        public string post_code { get; set; }
        public string country { get; set; }
        public string country_abbreviation { get; set; }
        public List<PlaceDetail> places { get; set; }

        public class PlaceDetail
        {
            public string place_name { get; set; }
            public string longitude { get; set; }
            public string state { get; set; }
        }
    }
}
