using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_GurvirSingh_Lab
{
    class Teacher : Person
    {
        private string m_teacherID;
       
        public string TeacherID
        {
            get
            {
                return m_teacherID;
            }
            set
            {
               m_teacherID = value;
            }
        }
        
        public Teacher(string name, int age, string teacher_id) 
            :base(name,age)
        {
            TeacherID = teacher_id;
        }

        public void Teaches()
        {
            Console.WriteLine($"{Name} is teaching.");
        }
        public override string ToString()
        {
            string output = "";
            
            output += $"Name: {Name}         \n";
            output += $"Age: {Age}          \n";
            output += $"TeacherID: {TeacherID}    \n";
            
            return output;
        }
    }
}
