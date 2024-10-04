
using MyPrototypeApp.Enums;
using MyPrototypeApp.Models.Cars;
using MyPrototypeApp.Models.Engines;

var truck1 = new Truck(new Engine(5000, EngineType.InternalCombustionEngine),DateTime.Now,"КРАЗ",6000);
var truck2 = truck1.Clone();
var truck3 = truck1.MyClone();

Console.WriteLine($"truck1:{truck1.ToString()}");
Console.WriteLine($"truck2:{truck2.ToString()}");
Console.WriteLine($"truck3:{truck3.ToString()}");

var car1 = new PassengerCar(new Engine(5000, EngineType.HybridEngine), DateTime.Now, "ВАЗ", 6000);
var car2 = car1.Clone();
var car3 = car1.MyClone();

Console.WriteLine($"truck1:{car1.ToString()}");
Console.WriteLine($"truck2:{car2.ToString()}");
Console.WriteLine($"truck3:{car3.ToString()}");
