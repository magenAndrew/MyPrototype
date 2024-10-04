using MyPrototypeApp.Enums;
using MyPrototypeApp.Models.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPrototypeApp.Models.Engines
{
    public class Car : Transport,  ICloneable, IMyClonable<Car>
    {
        public Car(Engine engine, DateTime dateCreation, string carBrand) : base(engine)
        {
            DateCreation = dateCreation;
            СarBrand = carBrand;
        }

        public DateTime DateCreation { get; private set; }
        public string СarBrand { get; private set; }

        public virtual object Clone()
        {
            return MyClone();
        }

        public virtual Car MyClone()
        {
            return new Car ( new Engine(Engine.EPower, Engine.EType), DateCreation, СarBrand);
        }
        public override string ToString()
        {
            return $"Car DateCreation:{DateCreation},СarBrand:{СarBrand}  Engine( Power:{Engine.EPower}, Type: {Engine.EType.ToString()}";
        }

    }
}
