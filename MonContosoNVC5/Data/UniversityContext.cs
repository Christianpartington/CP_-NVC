using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MonContosoNVC5.Data
{
    /// <summary>
    /// The mistake was here!!! You used a DbSet instead of DbContext
    /// </summary>
    public class UniversityContext : DbContext
    {
        public UniversityContext() : base("UniversityContext")
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}