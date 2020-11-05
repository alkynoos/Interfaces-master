using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    class Boat : AutoMobile, IAutoMobileActions, IBoatActions
    {

        public Boat()
        {

        }

        public Boat(bool IsOn)
        {
            this.IsOn = IsOn;
        }

        public void SteerLeft()
        {
            Console.WriteLine("The boat is steering left");
            bool steer = true;
            Steer(steer);
        }

        public void Reverse()
        {
            Console.WriteLine("The boat is reversing");
        }

        public void SteerRight()
        {
            Console.WriteLine("The boat is steering right");
            bool steer = false;
            Steer(steer);
        }

        public void Steer(bool steer)
        {
            if (steer == true)

            {
                Console.WriteLine("The boat is steering left = true");
            }

            else
            {
                Console.WriteLine("The boat is steering right = false");
            }
        }
    }
}
