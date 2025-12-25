using InheritanceCodeByEntityFramWork.Models;
using Microsoft.EntityFrameworkCore;//to use the DbContext and DbSet classes

namespace EntityFrameWorkCodeFirst.Data
{
    internal class SamirContext: DbContext//to represent the session with the database and can be used to query and save instances of your entities
    {
        public DbSet<Person> People { get; set; }//to represent the Person table in the database
        public DbSet<Student> Students { get; set; }//to represent the Students table in the database
        public DbSet<Employee> Employees { get; set; }//to represent the Employee  table in the database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)//to configure the database to be used

        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=InheritancCode;Integrated Security=True;Encrypt=False");//connection string
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasKey(p => p.PersonId);//to make the primary key
            //modelBuilder.Entity<Person>().UseTptMappingStrategy();//to use the TPT mapping strategy
            modelBuilder.Entity<Person>().UseTpcMappingStrategy();//to use the TPC mapping strategy
            base.OnModelCreating(modelBuilder);
        }
    }
}
