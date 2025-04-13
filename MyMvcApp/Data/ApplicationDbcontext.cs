using System.Collections;
using Microsoft.EntityFrameworkCore;
using MyMvcApp.Models;

namespace MyMvcApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Person> Person { get; set; }
        public DbSet<MyMvcApp.Models.Employee> Employee { get; set; } = default!;
        public object Daily { get; internal set; }
        public IEnumerable HeThongPhanPhoi { get; internal set; }
    }
}