using Course_Management_System.DataAccessLayer.Abstracts;
using Course_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Management_System.DataAccessLayer.Concretes;

public class CourseDal : ICourseDal
{
    List<Course> courses;
    public CourseDal()
    {
        //2 tane kurs eklendi
        Course course1 = new Course();
        course1.CourseId = 1;
        course1.Name="Java";
        course1.Description = "Java Temelleri Öğretilmektedir";
        course1.Image = "java.png";
        course1.ProgressBar = 0;
        course1.Price = 100;
        course1.InsturctorId = 1;
        course1.CategoryId = 1;

        Course course2 = new Course();
        course2.CourseId = 2;
        course2.Name = "Python";
        course2.Description = "Python Temelleri Öğretilmektedir";
        course2.Image = "Python.png";
        course2.ProgressBar = 0;
        course2.Price = 100;
        course2.InsturctorId = 2;
        course1.CategoryId = 1;
        courses = new List<Course> { course1,course2 };
    }
    public void Add(Course course)
    {
      courses.Add(course);  
    }

    public List<Course> GetAll()
    {
        return courses;
    }

    public void Delete(Course course)
    {
        courses.Remove(course); 
    }

    public void Update(Course course)
    {
        Course existCourse = courses.Find(x => x.CourseId == course.CourseId);
        if (existCourse is null)
            return;
        existCourse.CourseId = course.CourseId;
        existCourse.Name= course.Name;
        existCourse.Description = course.Description;
        existCourse.Image = course.Image;
        existCourse.InsturctorId= course.InsturctorId;
        existCourse.ProgressBar = course.ProgressBar;
        existCourse.Price = course.Price;
        existCourse.CategoryId = course.CategoryId;
    }
}
