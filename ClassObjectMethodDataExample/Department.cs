using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectMethodDataExample
{
    internal class Department
    {
        public string Name { get; set; }
        private List<Student>Students { get; set; }

        public Department() { 
        Students = new List<Student>();
        
        }
        public List<Student> GetStudents()
       {

            return Students.ToList();
        }
        public string AddStudents(Student student)
        {
            if (Students.Count<10)
            {
                Students.Add(student);
                return "Added";
            }
            else
            {
                return "Sorry, cant add more than 10";
            }
        }
    }
}
