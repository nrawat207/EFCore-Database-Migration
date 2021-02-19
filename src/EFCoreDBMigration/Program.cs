using EFCoreDatabase.Migration.Entities;
using System;

namespace EFCoreDatabase.Migration
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new CompanyContext())
            {

                var dept = new Department()
                {
                    Name = "IT"
                };
                context.Departments.Add(dept);

                var emp = new Employee()
                {
                    Name = "Kiran",                    
                    Department = dept
                };
                context.Employees.Add(emp);

                context.SaveChanges();
            }
        }
    }
}
