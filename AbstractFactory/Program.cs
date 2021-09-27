using AbstractFactory.Classes;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Transport car = new Transport(new CarFactory());
            car.CreateEngine();
            car.Move();

            Transport airplane = new Transport(new AirplaneFactory());
            airplane.CreateEngine();
            airplane.Move();

            Console.ReadLine();
        }
    }
}
