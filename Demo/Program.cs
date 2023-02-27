using System;
using System.Collections.Generic;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreateDatabase();
            MyContext ctx = new MyContext();
            removeDemo01(ctx);
        }

        private static void removeDemo01(MyContext ctx)
        {
            ctx.Students.Remove(new Student { StudentId = 1 });
            ctx.SaveChanges();
        }

        private static void updateDemo02(MyContext ctx)
        {
            Student student = new Student()
            {
                StudentId = 2,
                Name = "mahaya",
                Sruname = "mahyaoo"
            };
            ctx.Students.Update(student);
            ctx.SaveChanges();
        }

        private static void updateDemo01(MyContext ctx)
        {
            Student student = ctx.Students.Find(1);
            student.Age = 28;
            ctx.SaveChanges();
        }

        private static void addDemo02(MyContext ctx)
        {
            List<Student> stds = new List<Student>()
            {
                new Student(){Age=12,Name="reza",Sruname="rezaii"},
                new Student(){Age=12,Name="sina",Sruname="sinaii"}
            };

            ctx.Students.AddRange(stds);
            ctx.SaveChanges();
        }

        private static void addDemo01(MyContext ctx)
        {
            Student student = new Student()
            {
                Age = 12,
                Name = "amir",
                Sruname = "zamani"
            };
            ctx.Students.Add(student);
            ctx.SaveChanges();
            Console.WriteLine("Done");
        }

        private static void CreateDatabase()
        {
            MyContext context = new MyContext();
            context.Database.EnsureCreated();
            Console.WriteLine("Done");
        }
    }
}
