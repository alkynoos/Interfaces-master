using Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        // when steer Left, Right  bool _steering(the property)<--left = true, right = true
        static void Main(string[] args)
        {
            // NO NO can't have instances of an abstract class or interface
            //AutoMobile auto = new AutoMobile();

            Console.WriteLine("car c");
            Car c = new Car(true);
            c.Start();
            c.SteerLeft();
            c.SteerRight();
            c.Reverse();
            c.Stop();

            Console.WriteLine("car car");
            Car car = new Car();
            Console.WriteLine(car.IsOn);
            car.Start();
            car.SteerLeft();
            car.SteerRight();
            car.Reverse();
            car.Stop();
            Console.WriteLine(car.IsOn);

            // with private set doesn't work
            //car.IsOn = false;

            car.Stop();
            Console.WriteLine(car.IsOn);

            Console.WriteLine("motorbike moto");
            MotorBike moto = new MotorBike();
            moto.Start();
            moto.SteerRight();
            moto.SteerLeft();
            moto.Stop();
            Console.WriteLine(moto.IsOn);

            Console.WriteLine("motorbike moto2");
            MotorBike moto2 = new MotorBike(true);
            Console.WriteLine(moto2.IsOn);
            moto2.Start();
            moto2.SteerRight();
            moto2.SteerLeft();
            moto2.Stop();
            Console.WriteLine(moto2.IsOn);



            Console.WriteLine("Boat boat");
            Boat boat = new Boat();
            boat.SteerRight();
            boat.SteerLeft();
            boat.Stop();
            boat.Reverse();
            Console.WriteLine(boat.IsOn);



            Console.WriteLine("Boat boat2");
            Boat boat2 = new Boat(true);
            Console.WriteLine(boat2.IsOn);
            boat2.SteerRight();
            boat2.SteerLeft();
            boat2.Stop();
            boat2.Reverse();
            Console.WriteLine(boat2.IsOn);

            Console.ReadLine();

        }
    }
}
