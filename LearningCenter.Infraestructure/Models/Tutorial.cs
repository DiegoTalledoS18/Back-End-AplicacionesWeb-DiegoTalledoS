namespace LearningCenter.Infraestructure;

public class Tutorial:BaseModel
{
    public int Id { get; set; }
    
    public string Title { get; set; }
    
    public int Year { get; set; }
    
    public int Categoryid { get; set; }
    public Category Category { get; set; }
}