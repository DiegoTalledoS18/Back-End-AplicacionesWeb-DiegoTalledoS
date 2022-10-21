namespace LearningCenter.Infraestructure;

public interface ICategoryRepository
{
    List<Category> getAll();

    Category getCategoryById(int id);

    Boolean create(string name);

    Boolean update(int id, string name);

    Boolean Delete(int id);
}