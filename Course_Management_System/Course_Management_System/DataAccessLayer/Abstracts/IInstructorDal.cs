using Course_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Management_System.DataAccessLayer.Abstracts;

public interface IInstructorDal
{
    void Add(Instructor instructor);
    void Delete(Instructor instructor);
    void Update(Instructor instructor);
    List<Instructor> GetAll();
}
