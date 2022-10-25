namespace LearningCenter.Infraestructure;

public interface ICategoryRepository
{
    List<Category> getAll();

    Category getCategoryById(int id);

    Task<bool> create(Category category);

    Boolean update(int id, Category category);

    Boolean Delete(int id);
}