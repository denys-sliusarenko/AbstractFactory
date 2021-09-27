using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Classes
{
    abstract class TransportFactory
    {
        public abstract Movement CreateMovement();
        public abstract Engine CreateEngine();
    }
}
