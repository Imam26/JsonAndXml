using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace XmlAndJson
{
    [Serializable]
    [DataContract]
    public class Storage
    {
        
        private string name;
        
        private string model;
        [DataMember]
        public double Speed { get; set; }

        [DataMember]
        public string Name
        {
            get => name;
            set => name = value;
        }

        [DataMember]
        public string Model
        {
            get => model;
            set => model = value;
        }

        public Storage()
        {
            name = model = "default";
        }

        public Storage(string name, string model, double speed)
        {
            Name = name;
            Model = model;
            Speed = speed;
        }
    }
}
