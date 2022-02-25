using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RudraRug.Data;
using System;
using System.Linq;

namespace RudraRug.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RudraRugContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RudraRugContext>>()))
            {
                // Look for any movies.
                if (context.Rug.Any())
                {
                    return;   // DB has been seeded
                }

                context.Rug.AddRange(
                    new Rug
                    {
                        Manufacturer = "Madhurav Mills",
                        Material = "Wool",
                        Origin = "USA",
                        Property = "Dust resistance",
                        Color = "Blue",
                        Rating = 5,
                        Price = 270
                    },

                    new Rug
                    {
                        Manufacturer = "Patel Mills",
                        Material = "Wool",
                        Origin = "India",
                        Property = "Water resistance",
                        Color = "Sky Blue",
                        Rating = 4,
                        Price = 300
                    },

                    new Rug
                    {
                        Manufacturer = "Shah Mills",
                        Material = "Cotton",
                        Origin = "Australia",
                        Property = "Washable",
                        Color = "Grey",
                        Rating = 3,
                        Price = 220
                    },

                    new Rug
                    {
                        Manufacturer = "Patel Mills",
                        Material = "Jute",
                        Origin = "Canada",
                        Property = "Dust and Water resistance",
                        Color = "Baby Pink",
                        Rating = 5,
                        Price = 350
                    },
                    new Rug
                    {
                        Manufacturer = "Madhurav Mills",
                        Material = "Sisal",
                        Origin = "USA",
                        Property = "Washable",
                        Color = "Brown",
                        Rating = 4,
                        Price = 300
                    },
                    new Rug
                    {
                        Manufacturer = "Shah Mills",
                        Material = "Wool",
                        Origin = "Australia",
                        Property = "Water resistance",
                        Color = "Light Red",
                        Rating = 5,
                        Price = 330
                    },
                    new Rug
                    {
                        Manufacturer = "Samnani Mills",
                        Material = "Jute",
                        Origin = "India",
                        Property = "Fire resistance",
                        Color = "Light Green",
                        Rating = 3,
                        Price = 250
                    },
                    new Rug
                    {
                        Manufacturer = "Shah Mills",
                        Material = "Wool and Cotton",
                        Origin = "Australia",
                        Property = "Moisture resistance",
                        Color = "Yellow",
                        Rating = 2,
                        Price = 120
                    },
                    new Rug
                    {
                        Manufacturer = "Dave Mills",
                        Material = "Nylon",
                        Origin = "Nepal",
                        Property = "Water resistance",
                        Color = "Blue",
                        Rating = 3,
                        Price = 180
                    },
                    new Rug
                    {
                        Manufacturer = "Desai Mills",
                        Material = "Wool",
                        Origin = "Afghanistan",
                        Property = "Fire resistance",
                        Color = "Pink",
                        Rating = 3,
                        Price = 200
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
