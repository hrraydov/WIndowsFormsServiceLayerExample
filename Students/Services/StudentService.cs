using Newtonsoft.Json;
using Students.Models;
using Students.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Students.Services
{
    public class StudentService : IStudentService
    {
        public void Add(Student student)
        {
            var students = GetAll();
            if (students.Count(x => x.Number == student.Number) > 0)
            {
                throw new Exception("Student with that number already exists");
            }
            students.Add(student);
            string json = JsonConvert.SerializeObject(students, Formatting.Indented);
            File.WriteAllText(@"Storage\students.json", json);
        }

        public List<Student> GetAll()
        {
            string json = File.ReadAllText(@"Storage\students.json");
            List<Student> students = JsonConvert.DeserializeObject<List<Student>>(json);
            if (students == null)
            {
                students = new List<Student>();
            }
            return students.OrderBy(x => x.Number).ToList();
        }

        public List<Student> GetAllWithExcellentGrade()
        {
            var students = GetAll();
            students = students.Where(x => x.AverageGrade >= 5.5).ToList();
            return students;
        }

        public void Update(Student student)
        {
            var students = GetAll();

            var studentToUpdate = students.Find(x => x.Number == student.Number);

            studentToUpdate.FirstName = student.FirstName;
            studentToUpdate.LastName = student.LastName;
            studentToUpdate.AverageGrade = student.AverageGrade;

            string json = JsonConvert.SerializeObject(students, Formatting.Indented);
            File.WriteAllText(@"Storage\students.json", json);
        }
    }
}