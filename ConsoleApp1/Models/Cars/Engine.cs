using MyPrototypeApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPrototypeApp.Models.Cars
{
    public  class Engine
    {
        public float EPower { get;}
        public EngineType EType { get; }

        public Engine(float enginePower, EngineType engineType)
        {
            EPower = enginePower;
            EType = engineType;
        }
    }
}
