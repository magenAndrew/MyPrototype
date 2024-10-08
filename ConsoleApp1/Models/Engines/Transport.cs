using MyPrototypeApp.Models.Cars;

namespace MyPrototypeApp.Models.Engines
{
    /// <summary>
    /// Базовый абстрактный класс транспортного средства
    /// </summary>
    public abstract class Transport 
    {
        /// <summary>
        /// Тип двигателя
        /// </summary>
        public Engine Engine { get;}
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="engine">Тип двигателя</param>
        public Transport(Engine engine)
        {
            Engine = engine;
        }
        /// <summary>
        /// Переопределение стандартной функции
        /// </summary>
        public override string ToString()
        {
            return $"Transport Engine( Power:{Engine.EPower}, Type: {Engine.EType.ToString()}";
        }

     }
}
