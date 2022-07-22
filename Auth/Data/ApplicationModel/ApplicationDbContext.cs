 
using ApplicationDb.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace LibsDb { }

public partial class ApplicationDbContext : DbContext
{
    public static string DefaultConnectionString = "app";
      //  "Server=127.0.0.1;" +        
    //    $"Database=SpbPublicLibs;" +
    //    "user id=sa;" +
    //    "pwd=Gye*34FRtw;" +        
     //   "MultipleActiveResultSets=True";

    public virtual DbSet<Message> Messages { get; set; }
    public virtual DbSet<Account> Accounts { get; set; }
    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<Person> Persons { get; set; }
    public virtual DbSet<Settings> Settings { get; set; }
    public virtual DbSet<Role> Roles { get; set; }
    public virtual DbSet<Group> Groups { get; set; }
    public virtual DbSet<UserGroups> UserGroups { get; set; }
 
    public virtual DbSet<Resource> Resources { get; set; }
    public virtual DbSet<Calendar> Calendars { get; set; }
    public virtual DbSet<News> News { get; set; }
    public virtual DbSet<Service> Services { get; set; }



    // факты 
    public virtual DbSet<LoginFact> LoginFacts { get; set; }

    public ApplicationDbContext( ) : base() { }

    public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options) : base(options) { }


    /// <summary>
    /// Настройка конфигурации контекста данных
    /// </summary>
    /// <param name="optionsBuilder"></param>
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        System.Console.WriteLine($"Установка свойств контекста данных");
        
        if (!optionsBuilder.IsConfigured)
        {
            System.Console.WriteLine($"\t {DefaultConnectionString}");
            optionsBuilder.UseInMemoryDatabase(DefaultConnectionString);
            


        }
    }

    public new void SaveChanges()
    {
        base.SaveChanges();
    }

    public Task SaveChangesAsync()
    {
        return base.SaveChangesAsync();
    }
}

