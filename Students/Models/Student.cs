using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Models
{
    public class Student
    {
        private Dictionary<string, double> grades;

        public Student()
        {
            grades = new Dictionary<string, double>();
        }

        public int Number { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Dictionary<string, double> Grades
        {
            get { return grades; }
            set { grades = value; }
        }

        [JsonIgnore]
        public string FullName
        {
            get
            {
                return FirstName + LastName;
            }
        }

        public double AverageGrade()
        {
            return Grades.Average(x => x.Value);
        }
    }
}
