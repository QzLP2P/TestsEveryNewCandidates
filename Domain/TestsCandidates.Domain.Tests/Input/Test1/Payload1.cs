using System.Net;
using TestsCandidates.Domain.Interfaces.BaseTypes;
using TestsCandidates.Domain.Tests.Seeder.Test1;

namespace TestsCandidates.Domain.Tests.Input.Test1
{
    public class Payload1
        : IBasePayload
    {
        public int Code { get; set; } = (int)HttpStatusCode.OK;
        public string Data { get; set; }

        public Payload1()
        {
            Data = Referee.SeedPersons(); 
        }
    }

}
