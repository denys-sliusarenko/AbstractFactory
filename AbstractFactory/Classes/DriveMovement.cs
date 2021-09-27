using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Classes
{
    class DriveMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Driving");
        }
    }
}