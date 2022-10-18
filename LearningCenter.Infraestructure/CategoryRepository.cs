namespace LearningCenter.Infraestructure;

public class CategoryRepository: ICategoryRepository


{
    public List<string> getAll()
    {
        return new List<string>() { "value1 v2 repository", "value2 v2 repository" };

        //new Tutorial().Datecreated
    }

    public string getCategoryById(int id)
    {
        throw new NotImplementedException();
    }

    public bool create(string name)
    {
        throw new NotImplementedException();
    }
}