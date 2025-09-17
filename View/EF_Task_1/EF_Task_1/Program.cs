using EF_Task_1.Context;
using Microsoft.EntityFrameworkCore;

namespace EF_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITIDbContext context = new ITIDbContext();
            // insert test data for all tables
            context.Students.Add(new Student { FName = "John", LName = "Doe", Address = "123 Main St", Age = 20 });
            context.Students.Add(new Student { FName = "Jane", LName = "Smith", Address = "456 Elm St", Age = 21 });
            context.Students.Add(new Student { FName = "Jim", LName = "Beam", Address = "789 Oak St", Age = 22 });
            context.Students.Add(new Student { FName = "Jill", LName = "Johnson", Address = "321 Pine St", Age = 23 });
            context.Students.Add(new Student { FName = "Jack", LName = "Brown", Address = "654 Maple St", Age = 24 });
            context.Students.Add(new Student { FName = "Jill", LName = "Johnson", Address = "321 Pine St", Age = 23 });
            context.Students.Add(new Student { FName = "Jack", LName = "Brown", Address = "654 Maple St", Age = 24 });
            context.Students.Add(new Student { FName = "Jill", LName = "Johnson", Address = "321 Pine St", Age = 23 });
            context.Students.Add(new Student { FName = "Jack", LName = "Brown", Address = "654 Maple St", Age = 24 });
            context.SaveChanges();
            // add migration
            //context.Database.Migrate();
            // update database
            //context.Database.Update();
            

        

        }
    }
}
