using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Classes
{
    class Transport
    {
        private Engine engine;
        private Movement movement;

        public Transport(TransportFactory factory)
        {
            engine = factory.CreateEngine();
            movement = factory.CreateMovement();
        }

        public void Move()
        {
            movement.Move();
        }

        public void CreateEngine()
        {
            engine.CreateEngine();
        }
    }
}