using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class AdapterPattern
    {
    }
    /// <summary>
    /// Target Interface
    /// </summary>
    interface IPlane
    {
        void Wings();
        void wheels();
        
    }

    class Airbus : IPlane
    {
        public void wheels()
        {
            Console.WriteLine("AirBus has 3 wheels...");
        }

        public void Wings()
        {
            Console.WriteLine("AirBus has 2 wings to fly");
        }
    }
    /// <summary>
    /// Adaptee Class
    /// </summary>
    public class Helicopter
    {
        public void Blades()
        {
            Console.WriteLine("Helicopter has blades to fly");
        }
    }
    /// <summary>
    /// Adapter - takes a
    /// </summary>
    public class HelicopterAdapter : IPlane
    {
        Helicopter _helicopter;
        public HelicopterAdapter(Helicopter helicopter)
        {
            _helicopter = helicopter;
        }

        public void wheels()
        {
            Console.WriteLine("Helicopter has no Wheels");
        }

        public void Wings()
        {
            _helicopter.Blades();
        }
    }

}
