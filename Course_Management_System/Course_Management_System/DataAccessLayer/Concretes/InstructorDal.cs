using Course_Management_System.DataAccessLayer.Abstracts;
using Course_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Management_System.DataAccessLayer.Concretes;

public class InstructorDal : IInstructorDal
{
    List<Instructor> instructors;
    public InstructorDal()
    {
        Instructor instructor1 = new Instructor();
        instructor1.InstructorId = 1;
        instructor1.Name = "Engin";
        instructor1.Surname = "Demiroğ";

        Instructor instructor2 = new Instructor();
        instructor2.InstructorId = 2;
        instructor2.Name = "Halit Enes";
        instructor2.Surname = "Kalaycı";
        instructors = new List<Instructor> { instructor1,instructor2};
    }
    public void Add(Instructor instructor)
    {
        //
    }

    public List<Instructor> GetAll()
    {
        return instructors;
    }

    public void Delete(Instructor instructor)
    {
        
    }

    public void Update(Instructor instructor)
    {
        //
    }

 
}
