using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_GurvirSingh_Lab
{
    class Person
    {
        //fields (private instance variables) 
        private string m_name;
        private int m_age;

        // public properties 
        public string Name
        {
            get
            {
                return m_name;
            }

            set
            {
                m_name = value;
            }
        }

        public int Age
        {
            get
            {
                return m_age;
            }

            set
            {
                m_age = value;
            }
        }

         // constrctor
        public Person(string name, int age)
        {
            m_name = name;
            m_age = age;
        }

        // public method
        public void SaysHello()
        {
            Console.WriteLine($"{Name} says Hello!");
        }

        public override string ToString()
        {
            string output = "";
           
            output += $"Name: {Name}         \n";
            output += $"Age : {Age}          \n";
           
            return output;
        }
    }
}
