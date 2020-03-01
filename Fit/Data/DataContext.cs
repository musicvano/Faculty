using Fit.Data.Config;
using Fit.Models;
using Microsoft.EntityFrameworkCore;

namespace Fit.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Building> Buildings { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Degree> Degrees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Funding> Fundings { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Rank> Ranks { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Relative> Relatives { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Specialty> Specialties { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Study> Studies { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BuildingConfig());
            modelBuilder.ApplyConfiguration(new CityConfig());
            modelBuilder.ApplyConfiguration(new CountryConfig());
            modelBuilder.ApplyConfiguration(new DegreeConfig());
            modelBuilder.ApplyConfiguration(new DepartmentConfig());
            modelBuilder.ApplyConfiguration(new FacultyConfig());
            modelBuilder.ApplyConfiguration(new FundingConfig());
            modelBuilder.ApplyConfiguration(new GroupConfig());
            modelBuilder.ApplyConfiguration(new PositionConfig());
            modelBuilder.ApplyConfiguration(new RankConfig());
            modelBuilder.ApplyConfiguration(new RegionConfig());
            modelBuilder.ApplyConfiguration(new SpecialtyConfig());
            modelBuilder.ApplyConfiguration(new StudentConfig());
            modelBuilder.ApplyConfiguration(new StudyConfig());
        }
    }
}