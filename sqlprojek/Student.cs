using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlprojek
{
    class Student
    {
       

        public string Name { get; set; } 
        public string Reg { get; set; }
        public string Class { get; set; }
        public string Section { get; set; }
        public Student(string name, string reg, string @class, string section)
        {
            Name = name;
            Reg = reg;
            Class = @class;
            Section = section;
        }
    }
}
