using RestAPI_NUnitCsharp090323.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI_NUnitCsharp090323.Tests
{
    internal class ReqresTests : RequestValidation
    {

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        [Category("ApiTest")]
        public void ReqResCreateUserTests()
        {
            ValidatePostRequest();

        }

    }
}
