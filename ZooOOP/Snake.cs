using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooOOP
{
    class Snake : Animal
    {
        private bool dangerous;

        public bool Dangerous
        {
            get { return dangerous; }
            set { dangerous = value; }
        }

        public Snake()
        {
            
        }

        public void IsDangerous()
        {
            if (dangerous)
            {
                Console.WriteLine("The snake is dangerous!");
            }
            else
            {
                Console.WriteLine("The snake is harmless...");
            }
        }

        public void Slither()
        {
            Console.WriteLine("Shimmy Shimmy");
        }
    }
}
