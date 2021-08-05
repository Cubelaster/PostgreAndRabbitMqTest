using Core.Enums;
using Core.Models.EfModels;
using DataAccessLayer.Translators;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace DataAccessLayer.Context
{
    public class PostgreContext : DbContext
    {
        public PostgreContext(DbContextOptions<PostgreContext> dbContextOptions) : base(dbContextOptions)
        {
            NpgsqlConnection.GlobalTypeMapper.MapEnum<TodoType>(nameTranslator: new CamelCaseTranslator());
        }

        public DbSet<TodoItem> TodoItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.HasPostgresEnum<TodoType>(nameTranslator: new CamelCaseTranslator());
        }
    }
}
