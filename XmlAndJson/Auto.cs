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
    public class Auto
    {
        private string mark;
        private string model;
        private string typeOfBody;
        private int maxSpeed;
        private float engineCapacity;
        private DateTime dateOfManufacture;

        [DataMember]
        public string Mark { get=>mark; set=>mark = value; }
        [DataMember]
        public string Model { get => model; set => model = value; }
        [DataMember]
        public string TypeOfBody { get => typeOfBody; set => typeOfBody = value; }
        [DataMember]
        public int MaxSpeed { get => maxSpeed; set => maxSpeed = value; }
        [DataMember]
        public float EngineCapacity { get => engineCapacity; set => engineCapacity = value; }
        [DataMember]
        public string DateOfManufacture { get => dateOfManufacture.ToString(); set => dateOfManufacture = DateTime.Parse(value); }

        public Auto()
        {
            typeOfBody = model = mark = "не указан";
        }

        public Auto(string mark, string model, string typeOfBody, int maxSpeed, float engineCapacity, DateTime date) : this(mark, model)
        {
            TypeOfBody = typeOfBody;
            MaxSpeed = maxSpeed;
            EngineCapacity = engineCapacity;
            DateOfManufacture = date.ToString();
        }

        public Auto(string mark, string model)
        {
            Mark = mark;
            Model = model;
        }
    }
}
