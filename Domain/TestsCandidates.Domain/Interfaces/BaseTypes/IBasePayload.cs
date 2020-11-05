using System;
using System.Collections.Generic;
using System.Text;

namespace TestsCandidates.Domain.Interfaces.BaseTypes
{
    public interface IBasePayload
        : IBaseResponse
    {
        public string Data { get; set; }
    }
}
