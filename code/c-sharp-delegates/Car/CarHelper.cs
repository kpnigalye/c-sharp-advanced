using System;

namespace c_sharp_delegates
{
    class CarHelper
    {
        static void SpeedChangeAlert(string message)
        {
            Console.WriteLine(message);
        }

        public static void ExecuteCarCommands()
        {
            Car car = new Car();
            car.StartCar();

            Console.Write("Enter Speed: ");
            int speed = Convert.ToInt32(Console.ReadLine());

            car.ChangeSpeed(speed, SpeedChangeAlert);

            car.StopCar();
        }
    }
}
