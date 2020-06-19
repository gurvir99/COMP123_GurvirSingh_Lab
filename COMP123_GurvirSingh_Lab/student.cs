using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_GurvirSingh_Lab
{
    class Student : Person
    {
       
        private string m_studentID;

        public string StudentID
        {
             get 
            {
                return m_studentID;
            }

            set 
            {
                m_studentID = value;
            }
        }
        public Student(string name, int age, string student_id)
            : base(name, age)
        {
            StudentID = student_id;
        }

        public void Studies()
        {
            Console.WriteLine($"{Name} is studying.");
        }

        public override string ToString()
        {
            string output = "";
            output += $"Name      : {Name}         \n";
            output += $"Age       : {Age}          \n";
            output += $"StudentID : {StudentID}    \n";
             return output;
        }
    }
}
