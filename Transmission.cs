using System;
using System.Collections.Generic;
using System.Text;

namespace MyCar
{
    class Transmission
    {
        int transLevel = 0;

        public bool CheckTransmission()
        {
            if (transLevel == 0)
                return true;
            else
                return false;
        }

        public void trUp()
        {
            if(transLevel < 3)
            {
                transLevel++;
                Console.WriteLine("Transmission UP");
            }
            else
            {
                throw new TransmissionException();
            }
        }

        public void trZero()
        {
            transLevel = 0;
        }

        public void trDown()
        {
            if (transLevel>0)
            {
                transLevel--;
                Console.WriteLine("Transmission DOWN");
            }
            else
            {
                throw new TransmissionException();
            }
        }

        public int GetLevel()
        {
            return transLevel;
        }
    }
}
