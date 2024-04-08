using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insta360Hub.Models.Responses
{
    public class StateResponse
    {
        public string fingerprint { get; set; }
        public State state { get; set; }
    }

    public class State
    {
        /// <summary>
        /// card state of the camera device. Available values:
        /// noCard: no card detected
        /// pass: A card detected with supported format
        /// noSpace: A card detected, but no space left
        /// invalidFormat::A card detected, but the format is not supported
        /// writeProtect: A card detected, with WriteProtected on
        /// otherError: Other unknown error
        /// </summary>
        public string _cardState { get; set; }
        public float batteryLevel { get; set; }
        public string storageUri { get; set; }
    }



    /*
    Sample Response:

{
    "fingerprint": "FPR_133378",
    "state": {
        "_cardState": "pass",
        "batteryLevel": 0.470000,
        "storageUri": "http://192.168.42.1:80/DCIM/Camera01/"
    }
}

     */

}
