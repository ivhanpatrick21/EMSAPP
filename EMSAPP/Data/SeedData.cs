using EMSAPP.Models;
using Microsoft.EntityFrameworkCore;

namespace EMSAPP.Data
{
    public static class SeedData
    {
        public static void SeedDefaultData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department(1, "Accounting"),
                new Department(2, "Human Resource")
                );

            modelBuilder.Entity<Employee>().HasData(
               new Employee
               {
                   EmployeeName = "Ivhan",
                   Id = 1,
                   DOB = DateTime.Now.AddYears(-20),
                   Email = "ivhan@gmail.com",
                   Phone = "09079260368",
                   DepartmentId = 1
                   

               });


            //modelBuilder.Entity<Employee>().HasData(
            //    new Employee(1, "Shopping", "For Birthday", false, DateTime.Now.AddDays(1)),
            //    new Employee(2, "Learn C#", "In Jump Trainin", false, DateTime.Now.AddDays(2)),
            //    new Employee(3, "Learn MSSQL", "In Jump Trainin", false, DateTime.Now.AddDays(2))
            //    );
        }
    }
}
