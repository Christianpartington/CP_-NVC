using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MonContosoNVC5.Data
{
    public class UniversityContext : DbSet
    {
        public UniversityContext() : base("UniversityContext")
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}