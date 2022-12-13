using Microsoft.EntityFrameworkCore;
using Student_Entity.Models;

namespace Student_Entity.Data
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options) 
        { 
            
        }

        public virtual DbSet<Student> Students { get; set; }

        // migration command == add-migration "Comment"
        //Update database command == update-database

        //Connection String 
    }
}
