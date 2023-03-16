using Newtonsoft.Json;
using RestAPI_NUnitCsharp090323.Features.HealthcareGov.NewFolder;
using RestAPI_NUnitCsharp090323.Features.NasaOpenAPI;
using RestAPI_NUnitCsharp090323.Request.NasaOpenAPI;
using RestAPI_NUnitCsharp090323.Request.NasaOpenAPI.Model;
using RestAPI_NUnitCsharp090323.Request.Reqres.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using static RestAPI_NUnitCsharp090323.Request.NasaOpenAPI.Model.Asteroids;

namespace RestAPI_NUnitCsharp090323.Core
{
    public class RequestValidation : ClientSetup
    {
        private HttpStatusCode statusCode;
        private Index healthcareRes;
        private CreateUserReq createUserReq;
        private TechTransfer techTransferResponse;
        private Apod apodResponse;
        private Asteroids asteroidResponse;
        private Articles healthcareResponse;
        private CreatePostResponse createPostResponse;
        string nameCameras = string.Empty;


        // NASA
        internal void ValidateResponseIsJsonNasa()
        {
            ExecuteGenericRequestNasa("planetary/apod?api_key=", Method.Get);

            apodResponse = JsonConvert.DeserializeObject<Apod>(response.Content);
            Console.WriteLine(response.Content);

            Assert.That(response.ContentType, Is.EqualTo("application/json"));
        }

        internal void ValidateResposeCopyrightApod()
        {
            ExecuteGenericRequestNasa("planetary/apod?api_key=", Method.Get);
            apodResponse = JsonConvert.DeserializeObject<Apod>(response.Content);
            Console.WriteLine(apodResponse);
            Assert.AreEqual(apodResponse.copyright, "Michael LuyTrier Observatory");
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

        }

        internal void ValidateResponseIsJsonNasaAsteroid()
        {
            ExecuteGenericRequestNasa("neo/rest/v1/neo/browse?api_key=", Method.Get);
            asteroidResponse = JsonConvert.DeserializeObject<Asteroids>(response.Content);
            Assert.That(response.ContentType, Is.EqualTo("application/json"));
            Assert.That(response.IsSuccessStatusCode, Is.True);

        }

        internal void ValidateResponseAsteroidSize()
        {
            {
                ExecuteGenericRequestNasa("neo/rest/v1/neo/browse?api_key=", Method.Get);
                asteroidResponse = JsonConvert.DeserializeObject<Asteroids>(response.Content);
                Assert.AreEqual(20, asteroidResponse.page.size);
                

            }
        }

        internal void ValidateResponseTechTransfer()
        {
            {
                ExecuteGenericRequestNasa("techtransfer/patent/?engine&api_key=", Method.Get);
                techTransferResponse = JsonConvert.DeserializeObject<TechTransfer>(response.Content);
                Console.WriteLine(techTransferResponse.count);
                Assert.That("46", Is.EqualTo(techTransferResponse.count));
                Assert.That(response, Is.Not.Null);
                Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            }
        }

      //POST - reqres
        internal void ValidatePostRequest()
        {
            string jsonBody = @"{
                name' = 'Name',
                    'job' = 'QA''
                }";
            request.AddBody(jsonBody);
            ExecuteGenericRequestReqres("api/users", Method.Post, jsonBody);


            
          
        }


        //Healthcare
        internal void ValidateResponsetitleHealthcare()
        {
            ExecuteGenericRequestHealthCare("api/articles.json", Method.Get);
            healthcareResponse = JsonConvert.DeserializeObject<Articles>(response.Content);
            Assert.That("/where-can-i-read-the-affordable-care-act", Is.EqualTo(healthcareResponse.articles[0].url));
            Assert.That(response.IsSuccessful, Is.True);
        }

    }

}

