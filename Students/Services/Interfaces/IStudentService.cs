using Students.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Services.Interfaces
{
    public interface IStudentService : IService
    {
        List<Student> GetAll();

        List<Student> GetAllWithExcellentGrade();

        void Add(Student student);

        void Update(Student student);
    }
}
