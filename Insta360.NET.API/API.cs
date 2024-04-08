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
        public Uri BaseUri { get; }

        public API()
        {
            BaseUri = new Uri("http://192.168.42.1");
        }


    }
}