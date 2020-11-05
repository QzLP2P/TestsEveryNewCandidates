using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using TestsCandidates.Domain.Interfaces.BaseTypes;
using TestsCandidates.Domain.Interfaces.Test1;
using TestsCandidates.Domain.Interfaces.Test1.Entities;

namespace TestsCandidates.Domain.Test1
{
    public class MyFirstTest
        : ITest1
    {

        public IBaseRequest Handle(IBasePayload payload)
        {
            var people = JsonConvert.DeserializeObject<List<Person>>(payload.Data);
            people = people.OrderByDescending(p => p.Age).ToList();

            return new Request { Result = JsonConvert.SerializeObject(people) };
        }

      
    }
}
