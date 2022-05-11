using Microsoft.EntityFrameworkCore;

namespace StudentsInfSystem
{
    internal class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Departament> Departaments { get; set; }
        public DbSet<Lecture> Lectures { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("Server=localhost; Database=SchoolDB; Trusted_Connection=True");
        }
    }
}
