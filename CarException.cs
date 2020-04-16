using System;
using System.Collections.Generic;
using System.Text;

namespace MyCar
{
    class CarException
    {
    }

    class TransmissionException : Exception
    {
        public override string Message => "Transmission error";
    }
    class EngineNotStarted : Exception
    {
        public override string Message => "First start engine";
    }

    class WheelPressureException : Exception
    {
        public override string Message => "Check tyre pressure";
    }
        
        

}
