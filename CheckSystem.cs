using System;
using System.Collections.Generic;
using System.Text;

namespace MyCar
{
    class CheckSystem
    {
        Transmission transmission = new Transmission();
        Wheels w = new Wheels();
        public bool Check()
        {
            if (transmission.CheckTransmission() && w.CheckWheels())
            {
                return true;
            }
            return false;
        }

        public bool SystemStop()
        {
            transmission.trZero();
            return true;
        }
    }
}
