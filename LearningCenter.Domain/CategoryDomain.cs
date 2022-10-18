using LearningCenter.Infraestructure;

namespace LearningCenter.Domain;

public class CategoryDomain : ICategoryDomain
{
    private ICategoryRepository _categoryRepository;
    
    public CategoryDomain(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }
    
    public List<string> getAll()
    {
        return _categoryRepository.getAll();
    }

    public string getCategoryById(int id)
    {
        return "Body from domain v2 "+id.ToString();
    }

    public bool CreateCategory(string name)
    {
        throw new NotImplementedException();
    }
}