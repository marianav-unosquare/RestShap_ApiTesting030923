using RestSharp;

namespace RestAPI_NUnitCsharp090323
{
    public class Test : RequestValidationMethods
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ApiTest()
        {

            RestClient client = new RestClient("http://api.zippopotam.us");
            RestRequest request = new RestRequest("nl/3825", Method.Get);

            RestResponse response = client.Execute(request);

            // assert
            Assert.That(response.ContentType, Is.EqualTo("application/json"));
        }

        [Test]
        [Category("ApiTest")]
        public void ValidateJsonResponse()
        {
            ValidateStatusCode();
            ValidateResponseIsJson();
            ValidateResponseIsNetherlands();
        }

        [Test]
        [Category("ApiTest")]
        public void ValidatePostResponse()
        {
            ValidatePostExampleResponse();
        }
    }
}