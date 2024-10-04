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
