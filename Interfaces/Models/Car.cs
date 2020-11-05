using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    class Car : AutoMobile, IAutoMobileActions, ICarActions
    {
		public Car()
		{

		}

		public Car(bool IsOn)
		{
			this.IsOn = IsOn;
		}

		public void SteerLeft()
		{
			Console.WriteLine("The car is steering left");
			bool steer = true;
			Steer(steer);
		}

		public void Break()
		{
			Console.WriteLine("The car is breaking");
		}

		public void Reverse()
		{
			Console.WriteLine("The car is reversing");
		}

		public void SteerRight()
		{
			Console.WriteLine("The car is steering right");
			bool steer = false;
			Steer(steer);
		}

		public void Steer(bool steer)
		{
			if(steer == true)

			{
				Console.WriteLine("The car is steering left = true");
			}

			else
			{
				Console.WriteLine("The car is steering right = false");
			}
		}
	}
}
