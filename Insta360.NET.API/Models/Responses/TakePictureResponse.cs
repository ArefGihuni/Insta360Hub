using Insta360Hub.Models.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insta360.NET.API.Models.Responses
{
    public class TakePictureResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("progress")]
        public Progress Progress { get; set; }

        public bool IsDone
        {
            get
            {
                return State == "done";
            }
        }
    }

}
