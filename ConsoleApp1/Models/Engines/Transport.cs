using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using MyPrototypeApp.Enums;
using MyPrototypeApp.Models.Cars;

namespace MyPrototypeApp.Models.Engines
{
    public abstract class Transport 
    {
        public Engine Engine { get;}

        public Transport(Engine engine)
        {
            Engine = engine;
        }

        public override string ToString()
        {
            return $"Transport Engine( Power:{Engine.EPower}, Type: {Engine.EType.ToString()}";
        }
    }
}
