using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectMethodDataExample
{
    internal class Student
    {
        public Student(string regNo) 
        {
            RegNo = regNo;      
        }
        public Student()
        { 
        
        
        }

        public Student(string regNo, string name) : this(regNo)
        {
            Name = name;
           
        }

        public string RegNo {  get; set; }
        public string Name { get; set; }
        public Result StudentResult { get; set; }
    }
}
