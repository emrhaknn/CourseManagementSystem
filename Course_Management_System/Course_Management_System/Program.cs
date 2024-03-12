
using Course_Management_System.Business.Abstracts;
using Course_Management_System.Business.Concrete;
using Course_Management_System.DataAccessLayer.Concretes;
using Course_Management_System.Entities;

IGenericServices<Course> courseManager = new CourseManager(new CourseDal());
Course course3 = new Course();
course3.CourseId = 3;
course3.Name = "C";
course3.Description = "C Temelleri Öğretilmektedir";
course3.Image = "C.png";
course3.ProgressBar = 0;
course3.Price = 100;
course3.InsturctorId = 1;
course3.CategoryId = 1;
courseManager.Add(course3); //Kurs Ekleme
//courseManager.Delete(course3); Kurs Silme
//Kurs GÜncelleme
Course updatedCourse = new Course();
updatedCourse.CourseId = 3;
updatedCourse.Name = "C++";
updatedCourse.Description = "C++ Temelleri Öğretilmektedir";
updatedCourse.Image = "C++.png";
updatedCourse.ProgressBar = 0;
updatedCourse.Price = 100;
updatedCourse.InsturctorId = 1;
updatedCourse.CategoryId = 1;

courseManager.Update(updatedCourse);

List<Course> courses = courseManager.GetAll();
for (int i = 0; i < courses.Count; i++)
{
    Console.WriteLine($"ADI {courses[i].Name} /  Açıklaması {courses[i].Description} / Fiyatı  {courses[i].Price} /İlerleme %{courses[i].ProgressBar}");
}


