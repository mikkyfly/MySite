using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MyResume.Domain.Entities;



namespace MyResume.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "604c5388-0f54-4307-88df-447964ef272d", 
                Name ="admin",
                NormalizedName ="ADMIN"
            });

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id= "5e7dbdf5-dfce-46b0-af9e-4b14e4a08eaf",
                UserName = "admin",
                NormalizedUserName="ADMIN",
                Email="my@email.com",
                NormalizedEmail="MY@EMAIL.COM",
                EmailConfirmed=true,
                PasswordHash= new PasswordHasher<IdentityUser>().HashPassword(null,"superpassword"),
                SecurityStamp = string.Empty
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId= "604c5388-0f54-4307-88df-447964ef272d",
                UserId= "5e7dbdf5-dfce-46b0-af9e-4b14e4a08eaf"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new System.Guid("76be0127-64ae-45df-9bdb-a8c61ea2a5b3"),
                CodeWord = "PageIndex",
                Title = "Главная"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new System.Guid("7fe4c602-1ab5-4540-b2f7-e57ff289816b"),
                CodeWord = "PageServices",
                Title = "Услуги"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new System.Guid("8ab39a5b-716d-4319-b7fe-931c5bec7afa"),
                CodeWord = "PageContacts",
                Title = "Контакты"
            });
        }
    }
}
