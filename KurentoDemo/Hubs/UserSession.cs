using Kurento;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System;
using System.Net.WebSockets;
using System.Linq;
using KurentoDemo.Models;
using Newtonsoft.Json;
using Kurento.NET;

namespace KurentoDemo
{
    public class UserSession
    {
        public string Id { set; get; }
        public string UserName { set; get; }
        [JsonIgnore]
        public WebRtcEndpoint SendEndPoint { set; get; }
        [JsonIgnore]
        public ConcurrentDictionary<string, WebRtcEndpoint> ReceviedEndPoints { set; get; }
    }
}
