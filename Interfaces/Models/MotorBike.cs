using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    class MotorBike : AutoMobile, IAutoMobileActions, IMotorBikeActions
    {
		
		public MotorBike()
		{

		}

		public MotorBike(bool IsOn)
		{
			this.IsOn = IsOn;
		}

		public void SteerLeft()
		{
			Console.WriteLine("The motorbike is steering left");
			bool steer = true;
			Steer(steer);
		}

		public void Break()
		{
			Console.WriteLine("The motorbike is breaking");
		}

		public void SteerRight()
		{
			Console.WriteLine("The motorbike is steering right");
			bool steer = false;
			Steer(steer);
		}

		public void Steer(bool steer)
		{
            if (steer == true)
            {
				Console.WriteLine("The motorbike is steering left = true");
            }
            else
            {
				Console.WriteLine("The motorbike is steering right = false");
			}
		}
	}
}
