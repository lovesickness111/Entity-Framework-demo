namespace TodoList.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WorkDBContext : DbContext
    {
        public WorkDBContext()
            : base("name=WorkDBContext")
        {
        }

        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public System.Data.Entity.DbSet<TodoList.Models.Work> Works { get; set; }
    }
}
