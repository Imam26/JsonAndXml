using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace XmlAndJson
{
    [Serializable]
    [DataContract]
    public class Person
    {
        [DataMember]
        public string Name { set; get; }
        [DataMember]
        public string SurName { set; get; }
        [DataMember]
        public string FatherName { set; get; }

        public Person()
        {
            Name = SurName = FatherName = "";
        }

        public Person(string name, string surName, string fatherName)
        {
            Name = name;
            SurName = surName;
            FatherName = fatherName;
        }

        public static string GetPerson(Person person)
        {
            return string.Format($"{person.Name} {person.SurName} {person.FatherName}");
        }
    }
}
