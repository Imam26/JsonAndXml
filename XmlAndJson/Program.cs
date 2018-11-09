using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Diagnostics;
using System.Runtime.Serialization.Json;

/*Создать три разных класса и по 2 объекта к каждому из них. 
Представить созданные объекты не только в виде кода. но и в виде xml и json документов.*/

namespace XmlAndJson
{
    class Program
    {
        static void Main(string[] args)
        {
            Storage hdd = new Storage("HDD", "Seagate", 7.2);
            Storage flash = new Storage("Flash", "Kingston", 3.6);
            Person ivan = new Person("Иван", "Иванов", "Иванович");
            Person pavel = new Person("Павел", "Павлов", "Павлович");
            Auto bmw = new Auto("BMW", "X5", "SUV", 240, 3, new DateTime(2005, 12, 12));
            Auto mitsubishi = new Auto("Mitsubishi", "Pajero", "SUV", 240, 3, new DateTime(2006, 11, 11));

            List<Storage> storages = new List<Storage> { hdd, flash};

            XmlSerializer xmlSerializerStorage = new XmlSerializer(typeof(List<Storage>));

            using(FileStream fStream = new FileStream("Storages.xml", FileMode.Create))
            {
                xmlSerializerStorage.Serialize(fStream, storages);
            }

            List<Person> persons = new List<Person> { ivan, pavel };

            XmlSerializer xmlSerializerPerson = new XmlSerializer(typeof(List<Person>));

            using (FileStream fStream = new FileStream("Persons.xml", FileMode.Create))
            {
                xmlSerializerPerson.Serialize(fStream, persons);
            }

            List<Auto> auto = new List<Auto> { bmw, mitsubishi };

            XmlSerializer xmlSerializerAuto = new XmlSerializer(typeof(List<Auto>));

            using (FileStream fStream = new FileStream("Auto.xml", FileMode.Create))
            {
                xmlSerializerAuto.Serialize(fStream, auto);
            }

            DataContractJsonSerializer jsonSerializeStorage = new DataContractJsonSerializer(typeof(List<Storage>));

            using (FileStream fStream  = new FileStream("Storages.json", FileMode.Create))
            {
                jsonSerializeStorage.WriteObject(fStream, storages);
            }

            DataContractJsonSerializer jsonSerializePerson = new DataContractJsonSerializer(typeof(List<Person>));

            using (FileStream fStream = new FileStream("Persons.json", FileMode.Create))
            {
                jsonSerializePerson.WriteObject(fStream, persons);
            }

            DataContractJsonSerializer jsonSerializeAuto = new DataContractJsonSerializer(typeof(List<Auto>));

            using (FileStream fStream = new FileStream("Auto.json", FileMode.Create))
            {
                jsonSerializeAuto.WriteObject(fStream, auto);
            }
        }
    }
}
