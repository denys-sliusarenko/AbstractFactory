using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Classes
{
    class CarFactory : TransportFactory
    {
        public override Engine CreateEngine()
        {
            return new PetrolEngine();
        }

        public override Movement CreateMovement()
        {
            return new DriveMovement();
        }
    }
}