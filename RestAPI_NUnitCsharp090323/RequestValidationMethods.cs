using Newtonsoft.Json;
using RestAPI_NUnitCsharp090323.Features.NasaOpenAPI;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI_NUnitCsharp090323
{
    public class RequestValidationMethods : ClientRestSetUp
    {
        private PlaceDetailsResponse placeDetailsResponse;
        private CreatePostResponse createPostResponse;
        string nameCameras = string.Empty;

        internal void ValidateStatusCode()
        {
           
        }


        internal void ValidateResponseIsJson()
        {
            ExecuteGenericRequest("nl/3825", Method.Get);

            placeDetailsResponse = JsonConvert.DeserializeObject<PlaceDetailsResponse>(response.Content);

            Assert.That(response.ContentType, Is.EqualTo("application/json"));
        }

        internal void ValidateResponseIsNetherlands()
        {
            ExecuteGenericRequest("nl/3825", Method.Get);

            placeDetailsResponse = JsonConvert.DeserializeObject<PlaceDetailsResponse>(response.Content);

            Assert.AreEqual(placeDetailsResponse.country, "Netherlands");
        }

        internal void ValidatePostExampleResponse()
        {
            ExecuteGenericRequest("mars-photos/api/v1/rovers/curiosity/photos?sol=1000&api_key=DEMO_KEY", Method.Get);

            createPostResponse = JsonConvert.DeserializeObject<CreatePostResponse>(response.Content);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(createPostResponse.photos[i].camera.name);
                Console.WriteLine(createPostResponse.photos[i].img_src);
            }

            Assert.AreEqual("FHAZ", createPostResponse.photos[0].camera.name);

        }
    }
}
