namespace NK.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NK_18_Context : DbContext
    {
        public NK_18_Context()
            : base("name=NK18Conn")
        {
        }

        public virtual DbSet<NK18> NK18 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NK18>()
                .Property(e => e.IME)
                .IsUnicode(false);

            modelBuilder.Entity<NK18>()
                .Property(e => e.PZP)
                .IsUnicode(false);

            modelBuilder.Entity<NK18>()
                .Property(e => e.MESTO)
                .IsUnicode(false);
        }
    }
}
