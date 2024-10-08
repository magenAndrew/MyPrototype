using MyPrototypeApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPrototypeApp.Models.Cars
{
    /// <summary>
    /// Двигатель для ТС.
    /// </summary>
    public  class Engine
    {
        public float EPower { get;}
        public EngineType EType { get; }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="enginePower"> мощность</param>
        /// <param name="engineType"> тип двигателя</param>
        public Engine(float enginePower, EngineType engineType)
        {
            EPower = enginePower;
            EType = engineType;
        }
    }
}
