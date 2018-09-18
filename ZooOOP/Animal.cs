using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooOOP
{
    class Animal
    {
        private String name;
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        private int yearOfBirth;
        public int YearOfBirth
        {
            get { return yearOfBirth; }
            set { yearOfBirth = value; }
        }

        protected bool tame; //protected is only accessible to parent and child classes, not "outsiders"
        public bool Tame
        {
            get { return tame; }
            set
            {
                if(tame == true) tame = true;
                if (tame == false) tame = value;
            }
        }

        //public Animal() { }
        //public Animal(string name, int yearOfBirth, bool tame)
        //{
        //    Name = name;
        //    YearOfBirth = yearOfBirth;
        //    Tame = tame;
        //}
    }
}
