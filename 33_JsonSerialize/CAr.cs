﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _32_Serialize
{

    public class Engine
    {
        public double Power { get; set; }

        public Engine(double power)
        {
            Power = power;
        }
        public Engine()
            : this(1.0)
        {

        }
        public override string ToString()
        {
            return $"Engine power :: {Power}";
        }
    }
    public class Car
    {
        //[XmlIgnore]
        public int id;
        private string brand;
        public string Brand { get => brand; set => brand = value ?? "Nobrand"; }
        public Engine Engine { get; set; }
        public Car(int id, string brand, double power)

        {
            this.id = id;
            Brand = brand;
            Engine = new Engine(power);
        }
        public Car()
            : this(0, "NoBrand", 1.0)
        {

        }
        public override string ToString()
        {
            return $"Id :: {id}  Brand :: {Brand,-15} Engine power :: {Engine}";
        }

    }
}
