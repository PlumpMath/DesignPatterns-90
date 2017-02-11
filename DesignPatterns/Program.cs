using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton Pattern
            Console.WriteLine("**************************** Singleton Pattern *****************************");
            SingletonPattern ins = SingletonPattern.GetInstance();
            Console.WriteLine("1st Instance Id : " + ins.GetHashCode());
            SingletonPattern ins1 = SingletonPattern.GetInstance();
            Console.WriteLine("2st Instance Id : " + ins1.GetHashCode());
            Console.WriteLine("Both the Instance call has the same hashCode implies it is single/same instance");

            Console.WriteLine("**************************** Strategy Pattern *****************************");
            XmlFileReader xml = new XmlFileReader();
            xml.readFile();
            xml.writeFile();
            xml.EnableComment(new XmlComment());
            xml.writeFile();

            Console.WriteLine("**************************** Adapter Pattern *****************************");
            IPlane Helicopter = new HelicopterAdapter(new Helicopter());
            Helicopter.wheels();
            Helicopter.Wings();

            Console.WriteLine("**************************** Factory Pattern *****************************");
            Animal _tiger = AnimalFactory.GetAnimalInstance("Tiger");
            _tiger.Name();
            _tiger.FoodType();


            Console.ReadKey();
        }
    }
}
