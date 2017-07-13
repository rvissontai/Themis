namespace Themis.Migrations
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Themis.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Themis.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            context.Roles.AddOrUpdate(
                new IdentityRole() { Name = "Admin" },
                new IdentityRole() { Name = "Morador" }
            );

            //context.Users.AddOrUpdate(
            //        new Models.ApplicationUser()
            //        {
            //            Apto = "401",
            //            Bloco = "10",
            //            DataNascimento = new DateTime(1986, 1, 15),
            //            IsProprietario = false,
            //            Email = "rafael.vissontai@gmail.com",
            //            EmailConfirmed = true,
            //            PhoneNumber = "15997826505",
            //            PhoneNumberConfirmed = true,
            //            Sexo = 'M',
            //            UserName = "Rafael Vissontai de Oliveira",
            //            TwoFactorEnabled = false,
            //            LockoutEnabled = true,
            //            PasswordHash = "Senha123456"
            //        }
            //);

            //context.

                    //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
                    //  to avoid creating duplicate seed data. E.g.
                    //
                    //    context.People.AddOrUpdate(
                    //      p => p.FullName,
                    //      new Person { FullName = "Andrew Peters" },
                    //      new Person { FullName = "Brice Lambson" },
                    //      new Person { FullName = "Rowan Miller" }
                    //    );
                    //
        }
    }
}
