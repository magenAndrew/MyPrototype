/*
3. Составить тесты или написать программу для демонстрации функции клонирования.
 * */
using MyPrototypeApp.Enums;
using MyPrototypeApp.Models.Cars;
using MyPrototypeApp.Models.Engines;

var truck1 = new Truck(new Engine(5000, EngineType.InternalCombustionEngine),DateTime.Now,"КРАЗ",6000);
// Truck е = truck1.Clone(); //не работает
var truck2 = truck1.Clone();
Truck truck3 = truck1.MyClone();

Console.WriteLine($"truck1:{truck1.ToString()}");
Console.WriteLine($"truck2:{truck2.ToString()}");
Console.WriteLine($"truck3:{truck3.ToString()}");

var car1 = new PassengerCar(new Engine(5000, EngineType.HybridEngine), DateTime.Now, "ВАЗ", 6000);
var car2 = car1.Clone();
var car3 = car1.MyClone();

Console.WriteLine($"truck1:{car1.ToString()}");
Console.WriteLine($"truck2:{car2.ToString()}");
Console.WriteLine($"truck3:{car3.ToString()}");

// Написать вывод: какие преимущества и недостатки у каждого из интерфейсов: IMyCloneable и ICloneable.
/*
 * ICloneable
 * Плюсы:
 *  - Уже есть для многих обзектов .NET и сторонних библиотек
 * Минусы:
 *  - Возвращаемый тип != типу клонируемого объекта
 * 
 * IMyClonable
 * Плюсы:
 * - моральное удовлетворение, что контролируешь все сам.
 * - возвращаемый тип == типу клонируемого объекта
 * Минусы:
 *  - он есть только в этом проекте
 *  
 * */