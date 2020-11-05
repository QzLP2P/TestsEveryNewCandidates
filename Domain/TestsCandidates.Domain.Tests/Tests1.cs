using Newtonsoft.Json;
using NUnit.Framework;
using Shouldly;
using System.Net;
using TestsCandidates.Domain.Test1;
using TestsCandidates.Domain.Tests.Input.Test1;
using TestsCandidates.Domain.Tests.Seeder.Test1;

namespace TestsCandidates.Domain.Tests
{
    public class Tests1
    {
        [SetUp]
        public void Setup()
        {
            // uri ?
        }

        [Theory]
        public void First()
        {
            // Arrange
            var first = new MyFirstTest();
            var payload1 = new Payload1();

            var request = first.Handle(payload1);

            //Act
            // Send Request and get response
            // Check if response = OK
            //var response = first.Post(null);

            // In Referee Api receive request and check
            (bool isFine, string reason) = Referee.CheckResult(request.Result);
            isFine.ShouldBeTrue(reason);

            // Assert
            //response.ShouldNotBeNull();
            //response.Code.ShouldBe((int)HttpStatusCode.OK);
        }
    }
}