using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Classes
{
    class JetEngine : Engine
    {
        public override void CreateEngine()
        {
            Console.WriteLine("Creating jet engine...");
        }
    }
}
