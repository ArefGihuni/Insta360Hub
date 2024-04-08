using Insta360.NET.API.Models.Enums;
using Insta360.NET.API.Models.Requests;
using Insta360.NET.API.Models.Responses;
using Insta360Hub.Models.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Insta360.NET.API
{
    public class API
    {
        public Uri BaseUri { get; private set; }

        public API()
        {
            BaseUri = new Uri("http://192.168.42.1");
        }

        public API(string ip)
        {
            if (!IsValidIP(ip))
                throw new Exception("Invalid IP");

            BaseUri = new Uri($"http://{ip}");
        }

        private bool IsValidIP(string ip)
        {
            if (string.IsNullOrWhiteSpace(ip) || !ip.Replace(".", "").All(char.IsDigit))
                return false;

            if (ip.Where(x => x == '.').Count() != 3)
                return false;

            return true;
        }

        public void SetNewCameraIP(string ip)
        {
            if (!IsValidIP(ip))
                throw new Exception("Invalid IP");

            BaseUri = new Uri($"http://{ip}");
        }


        public async Task<InfoResponse> GetInfoAsync()
        {
            using (var client = new HttpClient())
            {
                var uri = new Uri(BaseUri, "/osc/info");
                var response = await client.GetAsync(uri);
                if (!response.IsSuccessStatusCode)
                    return null;

                var content = await response.Content.ReadAsStringAsync();
                if (string.IsNullOrWhiteSpace(content))
                    return null;

                return JsonConvert.DeserializeObject<InfoResponse>(content);
            }
        }

        public async Task<StateResponse> GetStateAsync()
        {
            using (var client = new HttpClient())
            {
                var uri = new Uri(BaseUri, "/osc/state");
                var response = await client.PostAsync(uri, new StringContent(""));
                if (!response.IsSuccessStatusCode)
                    return null;

                var content = await response.Content.ReadAsStringAsync();
                if (string.IsNullOrWhiteSpace(content))
                    return null;

                return JsonConvert.DeserializeObject<StateResponse>(content);
            }
        }

    }
}