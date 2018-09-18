using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooOOP
{
    class Horse : Animal
    {
        public double TopSpeed; //dark blue == primitive data type
        
        public Horse()
        {
            Console.WriteLine("What is your horses name?");
            Name = Console.ReadLine();
            Console.WriteLine("When was it born?");
            YearOfBirth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How fast can it Run?");
            TopSpeed = Convert.ToDouble(Console.ReadLine());
        }

        //public Horse(string name, double topSpeed)
        //{
        //    Name = name;
        //    TopSpeed = topSpeed;
        //}

        private void Eat()
        {
            Console.WriteLine("Eating...");
        }

        public void Run()
        {
            if (2018 - YearOfBirth <= 1)
            {
                Console.WriteLine("weeeeeeii");
            }
            else
            {
                Console.WriteLine("Neigh Neigh!");
            }
            Console.WriteLine($"{Name} is running! at {TopSpeed} miles an hour! ");
            Eat();
        }

        public void Age()
        {
            Console.WriteLine($"Your horse {Name} is {2018 - YearOfBirth} years old!");
        }
    }
}
