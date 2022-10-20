using Microsoft.EntityFrameworkCore;

namespace LearningCenter.Infraestructure.Context;

public class LearningCentDB:DbContext//Esta clase hace referencia a la base de datos
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Tutorial> Tutorials { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured) //Aqui valido otra vez si mi BD esta configurado, sino lo vuelvo a configurar 5 Y HACEMOS LA MIGRACION 6 NUGET:Entity framework core tools
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 31));
            optionsBuilder.UseMySql("server=localhost;user=root;password=123456;database=learningcenterdb; ",serverVersion);
        }
    }
    public LearningCentDB() : base() //Entity Framework me dice que debo tener constructores
    {
      
    }
    public LearningCentDB(DbContextOptions<LearningCentDB> options) : base(options) //Entity Framework me dice que debo tener constructores
    {
    }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        
        base.OnModelCreating(builder);
        
        builder.Entity<Category>().ToTable("Categories");
        builder.Entity<Category>().HasKey(p => p.Id);
        builder.Entity<Category>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Category>().Property(c => c.Name).IsRequired().HasMaxLength(60);
        builder.Entity<Category>().Property(c => c.DateCreated).IsRequired().HasDefaultValue(DateTime.Now);
        builder.Entity<Category>().Property(c => c.IsActive).IsRequired().HasDefaultValue(true);
        
        
        builder.Entity<Tutorial>().ToTable("Tutorial");
        builder.Entity<Tutorial>().HasKey(p => p.Id);
        builder.Entity<Category>().Property(c => c.DateCreated).IsRequired().HasDefaultValue(DateTime.Now);
        builder.Entity<Category>().Property(c => c.IsActive).IsRequired().HasDefaultValue(true);


        builder.Entity<User>().ToTable("Users");
        builder.Entity<User>().HasKey(p => p.Id);
        builder.Entity<Category>().Property(c => c.DateCreated).IsRequired().HasDefaultValue(DateTime.Now);
        builder.Entity<Category>().Property(c => c.IsActive).IsRequired().HasDefaultValue(true);
        
        
      
        


        
      
        
    }
}