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

    public async Task<bool> create(Category category)
    {
        /*Category category = new Category();
        category.Name = name;
        category.Description ="Description" + name;
        category.Description ="Description" + name;*/

        using (var transaction=_learningCenterDb.Database.BeginTransactionAsync())//Empiezo la transaccion eñ using es para abrir y cerrar coneccion automaticamente
        {
            try
            {
                _learningCenterDb.Categories.AddAsync(category);//Agregado a nivel de memoria Y CON AddAsync
                _learningCenterDb.SaveChangesAsync(); //Agregado a la base de datos y con SaveAsync
                
                _learningCenterDb.Database.CommitTransactionAsync();//termino la transaccion

            }
            catch (Exception ex)
            {
                _learningCenterDb.Database.RollbackTransactionAsync();
            }
        }



        return true;
    }
    
    public bool update(int id,Category category)
    {
        //Category category = _learningCenterDb.Categories.Find(id);
        Category existingCategory = _learningCenterDb.Categories.Find(id);
        //category.Name = name;
        //category.Description = "Description"+name;

        existingCategory.Name = category.Name;
        existingCategory.Description = category.Description;
        existingCategory.DateUpdated=DateTime.Now;

        _learningCenterDb.Categories.Update(existingCategory);//Agregado a nivel de memoria
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