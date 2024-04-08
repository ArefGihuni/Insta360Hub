using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insta360Hub.Models.Responses
{
    public class Endpoints
    {
        public int httpPort { get; set; }
        public int httpUpdatesPort { get; set; }
    }

    public class InfoResponse
    {
        public string manufacturer { get; set; }
        public string model { get; set; }
        public string serialNumber { get; set; }
        public string firmwareVersion { get; set; }
        public string supportUrl { get; set; }
        public Endpoints endpoints { get; set; }
        public bool gps { get; set; }
        public bool gyro { get; set; }
        public int uptime { get; set; }
        public List<string> api { get; set; }
        public List<int> apiLevel { get; set; }
        /// <summary>
        ///  Indicates the current lens module type of the camera, only supported on ONE R. Available values are 4K, 4K_Selfie,Dual_Fisheye,Leica,Leica_Selfie. The Selfie suffix indicates the lens is facing the same direction with touch screen.
        /// </summary>
        public string _sensorModuleType { get; set; }
        public string _vendorVersion { get; set; }
    }


    /*
 
    Sample Response:

{
    "manufacturer": "Arashi Vision",
    "model": "Insta360 X3",
    "serialNumber": "XXXXX0000000XX",
    "firmwareVersion": "v1.0.86",
    "supportUrl": "https://www.insta360.com/product/insta360-onex3/",
    "endpoints": {
        "httpPort": 80,
        "httpUpdatesPort": 10080
    },
    "gps": true,
    "gyro": true,
    "uptime": 38,
    "api": [
        "/osc/info",
        "/osc/state",
        "/osc/checkForUpdates",
        "/osc/commands/execute",
        "/osc/commands/status"
    ],
    "apiLevel": [
        2
    ],
    "_sensorModuleType": "Dual_Fisheye",
    "_vendorVersion": "v1.1_build1"
}
      
     */

}
