using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Snake mySnake = new Snake();
            Horse myHorse = new Horse();
            //Horse mySecondHorse = new Horse();

            //Horse myHorse = new Horse();
            //Horse mySecondHorse = new Horse();

            //myHorse.Name = "Findus";
            //myHorse.TopSpeed = 3.14159;
            //myHorse.Run();
            //mySecondHorse.TopSpeed = myHorse.TopSpeed * 3;
            //mySecondHorse.Run();

            //Console.WriteLine("What is your horses name?");
            //myHorse.Name = Console.ReadLine();
            //Console.WriteLine("How fast can it Run?");
            //myHorse.TopSpeed = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("When was it born?");
            //myHorse.YearOfBirth = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("What is your second horses name?");
            //mySecondHorse.Name = Console.ReadLine();
            //Console.WriteLine("How fast can it Run?");
            //mySecondHorse.TopSpeed = Convert.ToDouble(Console.ReadLine());

            myHorse.Run();
            //myHorse.Age();
            //mySecondHorse.Run();    
            //mySecondHorse.Age();


            Console.ReadKey();
        }
    }
}
