using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TestsCandidates.Domain.Interfaces.BaseTypes;
using TestsCandidates.Domain.Tests.Input;

namespace TestsCandidates.Domain.Tests
{
    public class BaseTests
    {
        private readonly HttpClient client;
        private readonly string baseUri;

        public BaseTests()
        {
            client = new HttpClient();
            baseUri = "https://localhost:44312/api";
        }


        public async Task<IBasePayload> FetchData(string testFamily, string testName)
        {
            var uri = new Uri($"{baseUri}/{testFamily}/{testName}Get");
            var httpResponse = await client.GetAsync(uri);
            var response = await httpResponse.Content.ReadAsStringAsync();

            var payload = new Payload { Data = response };
            return payload;
        }

        public async Task<(bool, string)> PostData(string testFamily, string testName, IBaseRequest request)
        {
            var uri = new Uri($"{baseUri}/{testFamily}/{testName}Post");
            var json = JsonConvert.SerializeObject(request.Result);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var httpResponse = await client.PostAsync(uri, httpContent);
            var response = await httpResponse.Content.ReadAsStringAsync();
            var obj =  JsonConvert.DeserializeObject<BasePostResponse>(response);
            return (obj.IsFine, obj.Message);
        }

        protected class BasePostResponse
        {
            public bool IsFine { get; set; }
            public string Message { get; set; }
        }
    }
}
