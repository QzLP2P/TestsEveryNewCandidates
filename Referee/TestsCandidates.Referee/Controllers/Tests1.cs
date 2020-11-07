using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestsCandidates.Referee.Referees.Tests1;
using TestsCandidates.Referee.Response;

namespace TestsCandidates.Referee.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Tests1
        : ControllerBase
    {

        [HttpGet]
        public string FirstGet()
        {
            var data = First.SeedPersons();
            return data;
        }

        [HttpPost]
        public BasePostResponse FirstPost([FromBody] string value)
        {
            (bool isFine, string msg) = First.CheckResult(value);
            var response = new BasePostResponse { IsFine = isFine, Message = msg };
            return response;
        }
    }
}
