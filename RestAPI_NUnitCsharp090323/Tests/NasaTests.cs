using RestAPI_NUnitCsharp090323.Core;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI_NUnitCsharp090323.Tests
{
    public class NasaTests : RequestValidation
    {
        private HttpStatusCode responseCode;


        [SetUp]
        public void Setup()
        {

        }

        public static void Main()
        {

        }


        [Test]
        public void NasaApiTest()
        {
            RestClient client = new RestClient("https://api.nasa.gov/");
            RestRequest request = new RestRequest("planetary/apod?api_key=5ZpzNnl9vn4lC5f5xAXmvXWE2fzXETV4SdRfrpp6", Method.Get);
            RestResponse response = client.Execute(request);

            // assert
            Assert.That(response.ContentType, Is.EqualTo("application/json"));
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        [Category("ApiTest")]
        public void ValidateJsonResponseApod()
        {
            ValidateResponseIsJsonNasa();
            ValidateResposeCopyrightApod();
        }

        [Test]
        [Category("ApiTest")]
        public void ValidateJsonResponseAsteroids()
        {
            ValidateResponseIsJsonNasaAsteroid();
            ValidateResponseAsteroidSize();
        }

        [Test]
        [Category("ApiTest")]
        public void ValidateTechTransfer()
        {
            ValidateResponseTechTransfer();
        }

    }
}

