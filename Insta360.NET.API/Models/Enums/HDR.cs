using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insta360.NET.API.Models.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum HDR
    {
        off,
        hdr,
    }
}
