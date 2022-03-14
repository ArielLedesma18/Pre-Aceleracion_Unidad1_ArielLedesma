using Microsoft.EntityFrameworkCore;
using Pre_Aceleracion_Unidad1_ArielLedesma.Models;

namespace Pre_Aceleracion_Unidad1_ArielLedesma.Context
{
    public class UsersContext : DbContext
    {
        private const string Schema = "Users";

        public UsersContext(DbContextOptions<UsersContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema(Schema);
        }
        public DbSet<Comment>? Comments { get; set; }
        public DbSet<User>? Users { get; set; }
        public DbSet<Post>? Posts { get; set; }
    }
}
