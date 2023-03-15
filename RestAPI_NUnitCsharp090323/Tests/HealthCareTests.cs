using RestAPI_NUnitCsharp090323.Core;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI_NUnitCsharp090323.Tests
{
    public class HealtcareTests : RequestValidation
    {

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void HealthcareApiTest()
        {
            RestClient client = new RestClient("https://www.healthcare.gov/");
            RestRequest request = new RestRequest("api/articles.json", Method.Get);
            RestResponse response = client.Execute(request);
            // assert
            Assert.That(response.ContentType, Is.EqualTo("application/json"));
            Assert.That(response.StatusCode, Is.EqualTo(200));
        }

        [Test]
        [Category("ApiTest")]
        public void HealthCareTests()
        {
            ValidateResponsetitleHealthcare();
        }
    }
}
