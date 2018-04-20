namespace MVCCRUDKnockout.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TrialDBEntities : DbContext
    {
        public TrialDBEntities()
            : base("name=TrialDBEntities")
        {
        }

        public virtual DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
