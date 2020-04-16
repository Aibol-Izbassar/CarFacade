using System;

namespace MyCar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Car c = new Car();
            Console.WriteLine("Попытка ехать вперед не заводя машину");
            try
            {
                //c.Start();
                c.Forward();
            }
            catch(EngineNotStarted en) 
            {
                Console.WriteLine(en.Message);
            }


            Console.WriteLine("Попытка заглушить не завиденный двигатель");
            try
            {
                //c.Start();
                c.Stop();
            }
            catch (EngineNotStarted en) 
            {
                Console.WriteLine(en.Message);
            }



            Console.WriteLine("Попытка разогнаться больше чем на 3-ю ступень передачи скорости");
            try
            {
                c.Start();
                for (int i = 0; i < 100; i++)
                {
                    c.Forward();
                }
            }
            catch(TransmissionException tr) 
            {
               Console.WriteLine(tr.Message);
            }




            Console.WriteLine("Попытка ехать на спущенном колесе");
            try
            {
                c.Start();
                c.TurnLeft();
                c.TurnRight();
                c.TurnLeft();
                c.TurnRight();
                c.TurnLeft();
                c.TurnRight();
            }
            catch (WheelPressureException wh)
            {
                Console.WriteLine(wh.Message);
            }

            Console.WriteLine("Корректная остоновка ");
            c.Stop();

        }
    }
}
