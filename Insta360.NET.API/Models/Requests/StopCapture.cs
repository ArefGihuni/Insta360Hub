using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insta360.NET.API.Models.Requests
{
    public class StopCapture
    {
        [JsonProperty("name")]
        public string Name { get; } = "camera.stopCapture";

        public string GetJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
