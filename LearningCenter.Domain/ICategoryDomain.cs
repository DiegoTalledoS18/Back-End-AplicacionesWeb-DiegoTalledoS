namespace LearningCenter.Domain;

public interface ICategoryDomain
{
    List<string> getAll();
    string getCategoryById(int id);
    Boolean CreateCategory(string name);
}