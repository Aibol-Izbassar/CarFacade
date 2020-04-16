using System;
using System.Collections.Generic;
using System.Text;

namespace MyCar
{
    class Wheels
    {
        float WheelPressure = 2.2f;

        public void turnWheelRight()
        {
            Console.WriteLine("Wheels turned right");
            WheelPressure = -0.1f;
            CheckWheels();
        }

        public void turnWheelLeft()
        {
            Console.WriteLine("Wheels turned left");
            WheelPressure = -0.1f;
            CheckWheels();
        }

        public bool CheckWheels()
        {
            if (WheelPressure < 2.5f && WheelPressure > 1.8f)
            {
                return true;
            }
            else
            {
                throw new WheelPressureException();
            }
            
        }
    }
}
