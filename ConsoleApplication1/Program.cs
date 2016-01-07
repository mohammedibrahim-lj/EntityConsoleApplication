using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new DBCreate())
            {
                db.stuTabel.Add(new StudentTable() { StuName = "ibrahim", StuClass = "MCA" });
                db.SaveChanges();
                var ddata = db.stuTabel.ToList();
                foreach(var data in ddata)
                {
                    Console.WriteLine(data);

                }
                Console.Read();
            }
        }
    }
    class StudentTable
    {
        [Key]
        public int StudentID { get; set; }
        public String StuName { get; set; }
        public String StuClass { get; set; }
    }
    class DBCreate:DbContext
    {
        //public DBCreate()
        //{
        //    Database.SetInitializer(new DropCreateDatabaseAlways<DBCreate>());
        //}
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<StudentTable>().Property(t => t.StuName).IsRequired();
            //modelBuilder.Entity<StudentTable>().Property(t => t.StuName).IsOptional();
            modelBuilder.Entity<StudentTable>().HasKey(t => t.StudentID);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<StudentTable> stuTabel { get; set; }
    }
}
