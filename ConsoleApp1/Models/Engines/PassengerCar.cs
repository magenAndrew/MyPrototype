﻿using MyPrototypeApp.Models.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPrototypeApp.Models.Engines
{
    /// <summary>
    /// Легковой автомобиль
    /// </summary>
    public class PassengerCar : Car, ICloneable, IMyClonable<Car>
    {
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { get; }

        /// <summary>
        /// Легковой автомобиль
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="dateCreation"></param>
        /// <param name="carBrand"></param>
        /// <param name="maxSpeed"></param>
        public PassengerCar(Engine engine, DateTime dateCreation, string carBrand, int maxSpeed) : base(engine, dateCreation, carBrand)
        {
            MaxSpeed = maxSpeed;
        }
        /// <summary>
        /// Добавить к каждому классу реализацию стандартного интерфейса ICloneable и реализовать его функционал через уже созданные методы.
        /// </summary>
        /// <returns></returns>
        public override object Clone()
        {
            return MyClone();
        }
        /// <summary>
        /// Сделать возможность клонирования объекта для каждого из этих классов, используя вызовы родительских??? конструкторов.
        /// </summary>
        /// <returns></returns>
        public override PassengerCar MyClone()
        {
            return new PassengerCar(new Engine(Engine.EPower, Engine.EType), DateCreation, СarBrand, MaxSpeed);
        }
        /// <summary>
        /// Переопределение стандартной функции
        /// </summary>
        public override string ToString()
        {
            return $"PassengerCar DateCreation:{DateCreation},СarBrand:{СarBrand}, MaxSpeed:{MaxSpeed}  Engine( Power:{Engine.EPower}, Type: {Engine.EType.ToString()}";
        }

    }
}
