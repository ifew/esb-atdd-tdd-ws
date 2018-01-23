using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using web.Models;

namespace web.Services
{
    public class MemberService
    {
        private static readonly HttpClient client = new HttpClient();

        public void Register(RegisterModel registerModel)
        {
            var url = "http://localhost:5001/api/member/register";
            var result = Call(url, registerModel);
        }

        static async Task<String> Call(string url, object data)
        {
            string stringData = JsonConvert.SerializeObject(data);
            var contentData = new StringContent(stringData, System.Text.Encoding.UTF8,"application/json");
            HttpResponseMessage response = client.PostAsync(url, contentData).Result;

            string result = await response.Content.ReadAsStringAsync();

            return result;
        }

    }
}
