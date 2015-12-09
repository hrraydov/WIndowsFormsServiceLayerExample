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
        public int Number { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double AverageGrade { get; set; }

        [JsonIgnore]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
