using Microsoft.AspNetCore.Identity;
using ComiclyWebApp.Data.Enum;
using ComiclyWebApp.Models;
using ComiclyWebApp.Data;

namespace RunGroopWebApp.Data
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ComiclyDbConext>();

                context.Database.EnsureCreated();

                if (!context.Clubs.Any())
                {
                    context.Clubs.AddRange(new List<Club>()
                    {
                        new Club()
                        {
                            Title = "Weekly",
                            Image = "https://images.unsplash.com/photo-1612036782180-6f0b6cd846fe?q=80&w=2970&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                            Description = "This is the description of the first Club",
                            ClubCategory = ClubCategory.weekly,
                            Address = new Address()
                            {
                                Street = "123 Whew Street",
                                City = "Newcastle",
                                Postcode = "NE1 1AB"
                            }
                         },
                        new Club()
                        {
                            Title = "Monthly",
                            Image = "https://images.unsplash.com/photo-1588497859490-85d1c17db96d?q=80&w=2970&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                            Description = "This is the description of the second Club",
                            ClubCategory = ClubCategory.monthly,
                            Address = new Address()
                            {
                                Street = "456 Test Ave",
                                City = "Manchester",
                                Postcode = "M1 1BE"
                            }
                        }
                    });
                    context.SaveChanges();
                }
                //Comics
                if (!context.Comics.Any())
                {
                    context.Comics.AddRange(new List<Comic>()
                    {
                        new Comic()
                        {
                            Title = "Single",
                            Image = "hhttps://fabricmouse.co.uk/cdn/shop/products/image_57ee7ef1-a9b8-4c8d-a1c2-d65f81e24aa7_1296x.jpg?v=1602081771",
                            Description = "This is the description of the first Comic",
                            ComicCategory = ComicCategory.single,
                            Address = new Address()
                            {
                                Street = "123 Boop St",
                                City = "Beepville",
                                Postcode = "NE4 4PD"
                            }
                        },
                        new Comic()
                        {
                            Title = "Collected",
                            Image = "https://nypost.com/wp-content/uploads/sites/2/2020/04/sothebys-dc-comics-48.jpg?quality=75&strip=all",
                            Description = "This is the description of the first Comic",
                            ComicCategory = ComicCategory.collected,
                            AddressId = 5,
                            Address = new Address()
                            {
                                Street = "123 Derp Road",
                                City = "Smallville",
                                Postcode = "SM1 1SM"
                            }
                        }
                    });
                    context.SaveChanges();
                }
            }
        }

        // public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        // {
        //     using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
        //     {
        //         //Roles
        //         var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

        //         if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
        //             await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
        //         if (!await roleManager.RoleExistsAsync(UserRoles.User))
        //             await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

        //         //Users
        //         var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
        //         string adminUserEmail = "teddysmithdeveloper@gmail.com";

        //         var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
        //         if (adminUser == null)
        //         {
        //             var newAdminUser = new AppUser()
        //             {
        //                 UserName = "teddysmithdev",
        //                 Email = adminUserEmail,
        //                 EmailConfirmed = true,
        //                 Address = new Address()
        //                 {
        //                     Street = "123 Main St",
        //                     City = "Charlotte",
        //                     State = "NC"
        //                 }
        //             };
        //             await userManager.CreateAsync(newAdminUser, "Coding@1234?");
        //             await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
        //         }

        //         string appUserEmail = "user@etickets.com";

        //         var appUser = await userManager.FindByEmailAsync(appUserEmail);
        //         if (appUser == null)
        //         {
        //             var newAppUser = new AppUser()
        //             {
        //                 UserName = "app-user",
        //                 Email = appUserEmail,
        //                 EmailConfirmed = true,
        //                 Address = new Address()
        //                 {
        //                     Street = "123 Main St",
        //                     City = "Charlotte",
        //                     State = "NC"
        //                 }
        //             };
        //             await userManager.CreateAsync(newAppUser, "Coding@1234?");
        //             await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
        //         }
        //     }
        // }
    }
}