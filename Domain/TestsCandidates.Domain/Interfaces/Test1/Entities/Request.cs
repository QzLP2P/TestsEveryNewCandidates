
using TestsCandidates.Domain.Interfaces.BaseTypes;

namespace TestsCandidates.Domain.Interfaces.Test1.Entities
{
    public class Request
        : IBaseRequest
    {
        public string Result { get; set; }
    }
}