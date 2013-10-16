using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Chraft.Net
{
    class JsonMessage
    {
        public string text { get; set; }
        public string color { get; set; }
        public bool italic { get; set; }
        public string translate { get; set; }

        public JsonMessage(string text)
        {
            this.text = text;
        }

        public string serialize()
        {
            return JsonConvert.SerializeObject(this);
        }

        public void setColor(string color)
        {
            this.color = color;
        }
    }
}
