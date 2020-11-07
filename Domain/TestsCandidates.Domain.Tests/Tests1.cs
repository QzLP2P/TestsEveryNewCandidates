using NUnit.Framework;
using Shouldly;
using System.Threading.Tasks;
using TestsCandidates.Domain.Test1;

namespace TestsCandidates.Domain.Tests
{
    public class Tests1
        : BaseTests
    {
        [SetUp]
        public void Setup()
        {
            // uri ?
        }

        [Theory]
        public async Task First()
        {
            // Arrange
            var first = new MyFirstTest();

            //Act
            var payload = await FetchData(nameof(Tests1), nameof(First));
            var request = first.Handle(payload);
            (bool isFine, string reason) = await PostData(nameof(Tests1), nameof(First), request);

            // Assert
            isFine.ShouldBeTrue(reason);
      
        }
    }
}