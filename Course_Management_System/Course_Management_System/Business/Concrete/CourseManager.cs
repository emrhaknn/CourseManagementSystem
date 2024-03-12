using Course_Management_System.Business.Abstracts;
using Course_Management_System.DataAccessLayer.Abstracts;
using Course_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Management_System.Business.Concrete;

public class CourseManager : IGenericServices<Course>
{
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }
    public void Add(Course course)
    {
        _courseDal.Add(course);
    }

    public void Delete(Course course)
    {
        _courseDal.Delete(course);
    }

    public List<Course> GetAll()
    {
        return _courseDal.GetAll();
    }

    public void Update(Course course)
    {
        _courseDal.Update(course);
    }
}
