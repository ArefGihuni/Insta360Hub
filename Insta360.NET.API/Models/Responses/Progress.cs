using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insta360.NET.API.Models.Responses
{
    public class Progress
    {
        [JsonProperty("completion")]
        public int Completion { get; set; }
    }
}
