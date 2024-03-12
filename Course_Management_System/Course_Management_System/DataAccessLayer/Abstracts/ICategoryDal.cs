using Course_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Management_System.DataAccessLayer.Abstracts;

public interface ICategoryDal
{
    void Add(Category category);
    void Delete(Category category);
    void Update(Category category);
    List<Category> GetAll();
}
