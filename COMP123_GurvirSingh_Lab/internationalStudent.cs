using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_GurvirSingh_Lab
{
    class internationalStudent : Student
    {
        private string m_intAddress;
        public string IntAddress
        {
            get
            {
                return m_intAddress;
            }
            set
            {
                 m_intAddress = value;
            }
        }
        public internationalStudent(string name, int age, string studentID, string interAddress) 
            :base(name,age,studentID)
        {
             IntAddress = interAddress;
        }

        public void IsInternational()
        {
            Console.WriteLine($"{Name} is an international student.");
        }

        public override string ToString()
        {
            string output = "";
           
            output += $"Name: {Name}         \n";
            output += $"Age: {Age}          \n";
            output += $"StudentID: {StudentID}    \n";
            output += $"International Address: {IntAddress}    \n";
          
            return output;
        }
    }
}
