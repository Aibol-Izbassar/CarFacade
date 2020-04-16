using System;
using System.Collections.Generic;
using System.Text;

namespace MyCar
{
    class Car
    {
        Wheels wheel = new Wheels();
        Engine engine = new Engine();
        public void Start()
        {
            engine.StartEngine();
        }
        public void Stop()
        {
            engine.StopEngine();
        }

        public void TurnRight()
        {
            wheel.turnWheelRight();
        }
        public void TurnLeft()
        {
            wheel.turnWheelLeft();
        }
        public void Forward()
        {
            engine.Accelerate(500);
        }
        public void Break()
        {
            engine.Deccelerate(500);
        }
    }
}
