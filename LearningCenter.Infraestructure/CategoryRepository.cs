using LearningCenter.Infraestructure.Context;

namespace LearningCenter.Infraestructure;


public class CategoryRepository: ICategoryRepository{
    
    private LearningCentDB _learningCenterDb;

    public CategoryRepository(LearningCentDB learningCenterDb)
    {
        _learningCenterDb = learningCenterDb;
    }


    public List<Category> getAll()
    {
        return _learningCenterDb.Categories.Where(category=>category.IsActive == true).ToList();//ESTO ES LINKQ

        //return new List<string>() { "value1 v2 repository", "value2 v2 repository" };

        //new Tutorial().Datecreated
    }

    public Category getCategoryById(int id)
    {
        return _learningCenterDb.Categories.Find(id);
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

        _learningCenterDb.Categories.Update(category);//Agregado a nivel de memoria
        _learningCenterDb.SaveChanges(); //Agregado a la base de datos 

        return true;
    }

}