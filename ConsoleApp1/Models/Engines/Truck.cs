using MyPrototypeApp.Models.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPrototypeApp.Models.Engines
{
    public class Truck : Car, ICloneable, IMyClonable<Car>
    {
        public int LoadCapacity { get; set; }

        public Truck(Engine engine, DateTime dateCreation, string carBrand, int loadCapacity) : base(engine, dateCreation, carBrand)
        {
            LoadCapacity = loadCapacity;
        }

 
        public override object Clone()
        {
            return MyClone();
        }

        public override Truck MyClone()
        {
            return new Truck(new Engine(Engine.EPower, Engine.EType), DateCreation, СarBrand, LoadCapacity);
        }
        public override string ToString()
        {
            return $"Truck DateCreation:{DateCreation},СarBrand:{СarBrand}, LoadCapacity:{LoadCapacity}  Engine( Power:{Engine.EPower}, Type: {Engine.EType.ToString()}";
        }

    }
}
