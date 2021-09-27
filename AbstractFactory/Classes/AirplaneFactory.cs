using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Classes
{
    class AirplaneFactory : TransportFactory
    {
        public override Engine CreateEngine()
        {
            return new JetEngine();
        }

        public override Movement CreateMovement()
        {
            return new FlyMovement();
        }
    }
}
