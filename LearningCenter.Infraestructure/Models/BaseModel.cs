namespace LearningCenter.Infraestructure;

public abstract class BaseModel
{
    public DateTime DateCreated { get; set; }
    public DateTime? DateUpdated { get; set; }//Utilizamos ? para poder admitir datos nulos
    public bool IsActive { get; set; }
}