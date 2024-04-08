using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insta360.NET.API.Models.Responses
{
    public class SetOptionsResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        public bool IsDone
        {
            get
            {
                return State == "done";
            }
        }

        //TODO: other properties
    }
}
