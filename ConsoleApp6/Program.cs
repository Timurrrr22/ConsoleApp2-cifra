namespace EFCoreWithDoker
{
    //using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Reflection.Metadata;

    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } // Автоинкремент
        [Column(TypeName = "VARCHAR(50)")]
        public string Name { get; set; } // varchar(50)
        [Column(TypeName = "VARCHAR(100)")]
        public string Email { get; set; } // varchar(100)
        public int Age { get; set; } // integer
    }

    //public class ApplicationDbContext : DbContext
   // {
        //public DbSet<User> Users { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=localhost;Database=MyyyDB;User Id=sa;Password=aeryhRT_12!@;TrustServerCertificate=True;");
        //}


   // }

    internal class Program
    {
        static void Main(string[] args)
        {
            //using (var context = new ApplicationDbContext())
            //{
                //context.Database.EnsureCreated();
                //var user = new User
                //{
                   // Name = "John Doe",
                   // Email = "john.doe@example.com",
                   // Age = 30
                //};

                //context.Users.Add(user);
                //context.SaveChanges();
            //}
        }


    }
}

//Scaffold - DBContext "Server=localhost;Database=TestDB;User Id=sa;Password=;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer