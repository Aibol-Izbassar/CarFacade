using System;
using System.Collections.Generic;
using System.Text;

namespace MyCar
{
    class Engine
    {
        CheckSystem checkSystem = new CheckSystem();
        bool engCheckStart = false;
        int Rotations = 0;
        Transmission transmission = new Transmission();

        public void Accelerate(int rotation)
        {
            if (engCheckStart)
            {
                Rotations = Rotations + rotation;
                if (Rotations > 1500)
                {
                    transmission.trUp();
                    Rotations = Rotations - 1000;
                }
                else
                    Console.WriteLine("Rotations: " + Rotations);
            }
            else
                throw new EngineNotStarted();
            
        }

        public void Deccelerate(int rotation)
        {
            if (engCheckStart)
            {
                if (Rotations > 0 && Rotations > 1000)
                {
                    Rotations = Rotations - 500;
                    transmission.trDown();
                }
                else
                    Console.WriteLine("Rotations " + Rotations);
            }
            else
                throw new EngineNotStarted();
            

        }

        public void StartEngine()
        {
            if (checkSystem.Check() && engCheckStart == false)
            {
                Console.WriteLine("Engine Start");
                engCheckStart = true;
            }
        }

        public void StopEngine()
        {
            if (engCheckStart == true && checkSystem.SystemStop())
            {
                checkSystem.SystemStop();
                Rotations = 0;
                Console.WriteLine("Rotation: "+Rotations);
                Console.WriteLine("Engine Stop");
            }
            else
            {
                throw new EngineNotStarted();
            }
        }


    }
}
