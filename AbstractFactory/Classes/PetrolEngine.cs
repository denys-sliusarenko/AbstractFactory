using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Classes
{
    class PetrolEngine : Engine
    {
        public override void CreateEngine()
        {
            Console.WriteLine("Creating petrol engine...");
        }
    }
}