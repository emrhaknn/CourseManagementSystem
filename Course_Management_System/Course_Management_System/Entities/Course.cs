using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Management_System.Entities;

public class Course
{
    public int CourseId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }
    public int ProgressBar { get; set; }
    public int Price { get; set; }
    public int InsturctorId { get; set; }
    public int CategoryId { get; set; }

}
