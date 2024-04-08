using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Insta360.NET.API.Models.Enums;
using Newtonsoft.Json;

namespace Insta360.NET.API.Models.Requests
{

    public class Options
    {
        [JsonProperty("captureMode")]
        public CaptureModes CaptureMode { get; set; }

        [JsonProperty("hdr")]
        public HDR HDR { get; set; }
    }

    public class Parameters
    {
        [JsonProperty("options")]
        public Options Options { get; set; }
    }

    public class SetOptions
    {
        public SetOptions() { }

        public SetOptions(CaptureModes captureMode, HDR hdr)
        {
            this.Parameters = new Parameters()
            {
                Options = new Options()
                {
                    CaptureMode = captureMode,
                    HDR = hdr
                }
            };
        }

        [JsonProperty("name")]
        public string Name { get; } = "camera.setOptions";

        [JsonProperty("parameters")]
        public Parameters Parameters { get; set; }

        public string GetJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }



}
