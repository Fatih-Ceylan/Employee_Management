using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Models
{
    // appdbcontext sınıfını temiz tutmak için tüm içeriği buraya aktaracağız
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
             new Employee
             {
                 Id = 1,
                 Name = "mahmut",
                 Department = Dept.GM,
                 Email = "mahmut@aa.com"
             },
             new Employee
             {
                 Id = 2,
                 Name = "selin",
                 Department = Dept.HR,
                 Email = "selin@aa.com"
             }
             );
        }
    }
}
