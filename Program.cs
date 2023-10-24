using System;


namespace exHadasim
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Audi();
            Console.WriteLine("The speed of the vehicle car1 is: " + car1.GetCurrentSpeed());
            
            Console.WriteLine("How much do you want to accelerate the vehicle's speed? ");
            int acceleration = int.Parse(Console.ReadLine());
            car1.Accelerate(acceleration);

            Console.WriteLine("Vehicle data:" + car1);

            car1.Decelerate(2);
            Console.WriteLine("Vehicle data car1 after deceleration:" + car1);

            car1.Stop();
            Console.WriteLine("Vehicle data car1 after stopping: " + car1);

            var car2 = new Lexus();
            Console.WriteLine("The speed of the vehicle car2 is: " + car2.GetCurrentSpeed());

            Console.WriteLine("How much do you want to accelerate the vehicle's speed? ");
            acceleration = int.Parse(Console.ReadLine());
            car2.Accelerate(acceleration);

            Console.WriteLine("Vehicle data:" + car2);

            car2.PlayMusic();
            car2.Decelerate(2);
            Console.WriteLine("Vehicle data:" + car2);

            car2.StopMusic();
            Console.WriteLine("Vehicle data car2 after stopping the playback:" + car2);

            car2.Stop();
            Console.WriteLine("Vehicle data car2 after stopping: " + car2);



            
        }

        
    }
}
