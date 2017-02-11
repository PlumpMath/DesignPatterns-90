using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    /// <summary>
    /// Factory Pattern : faciliate to dynamically to create various instances of classes derived from super common class
    /// </summary>
    class FactoryPattern
    {
    }

   public abstract class Animal
    {
        public abstract void Name();
        public abstract void FoodType();
        
    }

    public class Elephant : Animal
    {
        public override void FoodType()
        {
            Console.WriteLine("Elephant is herviourious animal");
        }

        public override void Name()
        {
            Console.WriteLine("Elephant...");
        }
    }

    public class Tiger : Animal
    {
        public override void FoodType()
        {
            Console.WriteLine("Tiger is Canivorious animal");
        }

        public override void Name()
        {
            Console.WriteLine("Tiger...");
        }
    }

    public static class AnimalFactory
    {
        public static Animal GetAnimalInstance(string name)
        {
            if (name.ToLower() == "elephant")
                return new Elephant();

            if (name.ToLower() == "tiger")
                return new Tiger();

            return null;
        }
    }
}
