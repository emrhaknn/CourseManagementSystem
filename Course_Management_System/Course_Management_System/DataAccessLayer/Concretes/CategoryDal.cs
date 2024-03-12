using Course_Management_System.DataAccessLayer.Abstracts;
using Course_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Management_System.DataAccessLayer.Concretes;

public class CategoryDal : ICategoryDal
{
    List<Category> categories;
    public CategoryDal()
    {
        Category category1= new Category();
        category1.CategoryId = 1;
        category1.Name = "Programlama";
        Category category2 = new Category();
        category2.CategoryId = 2;
        category2.Name = "Elktronik";

        categories = new List<Category>() {category1,category2};
    }
    public void Add(Category category)
    {
        categories.Add(category);   
    }

    public List<Category> GetAll()
    {
       return categories;
    }

    public void Delete(Category category)
    {
        categories.Remove(category);    
    }

    public void Update(Category category)
    {

    }
}
