using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Employee.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<department> departments { get; set; }

        public DbSet<Emp> Emps { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<department>().HasData(
                   new department { id = 1, name = "HR" },
                   new department { id = 2, name = "IT" },
                   new department { id = 3, name = "Finance" },
                   new department { id = 4, name = "Admin" }
                );

            modelBuilder.Entity<Emp>().HasData(
                    new Emp
                    {
                        id = 1,
                        name = "John",
                        gender = "male",
                        city = "New York",
                        mobile = "1234567890",
                        salary = 50000,
                        departmentId = 1
                    },
                    new Emp
                    {
                        id = 2,
                        name = "Smith",
                        gender = "male",
                        city = "Los Angeles",
                        mobile = "1234567890",
                        salary = 60000,
                        departmentId = 2
                    },
                    new Emp
                    {
                        id = 3,
                        name = "Ravi",
                        gender = "male",
                        city = "Mumbai",
                        mobile = "1234567890",
                        salary = 70000,
                        departmentId = 3
                    },

                    new Emp
                    {
                        id = 4,
                        name = "Kavita",
                        gender = "female",
                        city = "Pune",
                        mobile = "1234567890",
                        salary = 80000,
                        departmentId = 4
                    }
                );
        }
    }
}
