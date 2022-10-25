using LearningCenter.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;

namespace LearningCenter.Infraestructure;


public class CategoryRepository: ICategoryRepository{
    
    private LearningCentDB _learningCenterDb;

    public CategoryRepository(LearningCentDB learningCenterDb)
    {
        _learningCenterDb = learningCenterDb;
    }


    public List<Category> getAll()
    {
        var filterByName = "Category";
        return _learningCenterDb.Categories.Where(category=>category.IsActive == true)
            .Include(category => category.Tutorials)//Con esto agrego que me devuelva los tutoriales y vamos a program  
            .Where(category => category.IsActive && category.Name.Contains(filterByName) && category.Id>8)
            .ToList();//ESTO ES LINKQ

        //return new List<string>() { "value1 v2 repository", "value2 v2 repository" };

        //new Tutorial().Datecreated
    }

    public Category getCategoryById(int id)
    {
        return _learningCenterDb.Categories
            .Include(category => category.Tutorials)//Con esto agrego que me devuelva los tutoriales y vamos a program  
            .SingleOrDefault(category =>category.Id==id );//SINGLEORDEFAULT ES COMO EL FIND(id)
    }

    public bool create(string name)
    {
        Category category = new Category();
        category.Name = name;
        category.Description = "Description"+name;

        _learningCenterDb.Categories.Add(category);//Agregado a nivel de memoria
        _learningCenterDb.SaveChanges(); //Agregado a la base de datos 

        return true;
    }
    
    public bool update(int id,string name)
    {
        Category category = _learningCenterDb.Categories.Find(id);
        category.Name = name;
        category.Description = "Description"+name;

        _learningCenterDb.Categories.Update(category);//Agregado a nivel de memoria
        _learningCenterDb.SaveChanges(); //Agregado a la base de datos 

        return true;
    }

    public bool Delete(int id)
    {
        Category category = _learningCenterDb.Categories.Find(id);

        category.IsActive = false;
        category.DateUpdated=DateTime.Now;

        _learningCenterDb.Categories.Update(category);//Agregado a nivel de memoria
        _learningCenterDb.SaveChanges(); //Agregado a la base de datos 

        return true;
    }

}