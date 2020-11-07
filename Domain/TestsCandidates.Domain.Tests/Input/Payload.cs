using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using TestsCandidates.Domain.Interfaces.BaseTypes;

namespace TestsCandidates.Domain.Tests.Input
{
    public class Payload
        : IBasePayload
    {
        public int Code { get; set; } = (int)HttpStatusCode.OK;
        public string Data { get; set; }
    }
}
