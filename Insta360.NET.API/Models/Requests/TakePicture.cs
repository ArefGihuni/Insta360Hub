using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insta360.NET.API.Models.Requests
{
    public class TakePicture
    {
        [JsonProperty("name")]
        public string Name { get; } = "camera.takePicture";

        public string GetJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
