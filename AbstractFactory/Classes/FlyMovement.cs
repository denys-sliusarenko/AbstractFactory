using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Classes
{
    class FlyMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Fly");
        }
    }
}
