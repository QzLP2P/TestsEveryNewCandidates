using Newtonsoft.Json;
using Shouldly;
using System.Collections.Generic;
using System.Linq;

namespace TestsCandidates.Domain.Tests.Seeder.Test1
{
    public static class Referee
    {
        public static string SeedPersons()
        {
            var p = new List<Person>
            {
                new Person { Age = 10, Name = "A"},
                new Person { Age = 11, Name = "B"},
                new Person { Age = 12, Name = "C"},
            };

            return JsonConvert.SerializeObject(p);
        }

        public static (bool, string) CheckResult(string input)
        {
            var p = JsonConvert.DeserializeObject<List<Person>>(input);

            if (p.Count() != 3)
                return (false, "Lenght should be '3'");

            if(p.First().Name != "C")
                return (false, "First item name should be 'C'");

            if (p.Last().Name != "A")
                return (false, "Last item name should be 'A'");

            return (true, "GG");
        }

        protected class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }
}
