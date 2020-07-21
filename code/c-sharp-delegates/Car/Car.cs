using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_delegates
{
    public class Car
    {
        public delegate void CarAlert(string message);

        public int MaxSpeedLimit { get; set; } = 100;
        public int MinSpeedLimit { get; set; } = 40;

        public void StartCar()
        {
            Console.WriteLine("Car Started");
        }

        public void StopCar()
        {
            Console.WriteLine("Car Stopped");
        }

        public void ChangeSpeed(int currentSpeed, CarAlert carAlert)
        {
            if (currentSpeed > MaxSpeedLimit)
            {
                carAlert("You are going above maximum speed limit");
            }
            else if (currentSpeed < MaxSpeedLimit)
            {
                carAlert("You are going below minimum speed limit");
            }
        }
    }
}
