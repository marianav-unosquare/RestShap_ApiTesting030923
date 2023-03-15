using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI_NUnitCsharp090323.Features.NasaOpenAPI
{
    public class CreatePostResponse
    {
        public List<PhotosDetails> photos { get; set; }
        public class PhotosDetails
        {
            public int id { get; set; }
            public string sol { get; set; }
            public CameraDetails camera { get; set; }
            public string img_src { get; set; }
        }

        public class CameraDetails
        {
            public string name { get; set; }
        }
    }
}
