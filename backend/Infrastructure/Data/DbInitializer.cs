using System;
using Domain;

namespace Infrastructure.Data;

public class DbInitializer
{

    public static async Task SeeData(AppDbContext context)
    {
        if (context.Clients.Any()) return;

        var client = new List<Client>
        {
            new(){
                Name = "John Doe",
                Email = "john.doe@email.com",
                Phone = "07123456789",
                Address = "12 Apple Road, London",
                BusinessName = "Tech Solutions Ltd",
                HasLeftReview = true,
                LastReviewDate = DateTime.UtcNow.AddDays(-20)
            },
            new() {
                Name = "Jane Smith",
                Email = "jane.smith@email.com",
                Phone = "07000000000",
                Address = "43 Pear St, Manchester",
                BusinessName = "Design Studio",
                HasLeftReview = false
            },
            new() {
                Name = "Samuel Jackson",
                Email = "sam.j@email.com",
                Phone = "07911110000",
                Address = "21 Banana Crescent, Birmingham",
                BusinessName = "Marketing Agency",
                HasLeftReview = true,
                LastReviewDate = DateTime.UtcNow.AddDays(-5)
            },
            new() {
                Name = "Linda Lee",
                Email = "linda.lee@email.com",
                Phone = "07888887777",
                Address = "77 Peach Ave, Leeds",
                BusinessName = "Consulting Services",
                HasLeftReview = true,
                LastReviewDate = DateTime.UtcNow.AddMonths(-1)
            },
            new() {
                Name = "Marcus Wright",
                Email = "marcus@email.com",
                Phone = "07222223333",
                Address = "5 Cherry Grove, Bristol",
                BusinessName = "Financial Advisors",
                HasLeftReview = false
            },
            new() {
                Name = "Tina Olamide",
                Email = "tina@email.com",
                Phone = "07040404040",
                Address = "19 Coconut Close, Croydon",
                BusinessName = "Legal Services",
                HasLeftReview = true,
                LastReviewDate = DateTime.UtcNow.AddDays(-12)
            },
            new() {
                Name = "Ben Turner",
                Email = "ben@email.com",
                Phone = "07555552222",
                Address = "9 Pineapple Walk, Glasgow",
                BusinessName = "E-commerce Solutions",
                HasLeftReview = false
            },
            new() {
                Name = "Alex Chan",
                Email = "alex@email.com",
                Phone = "07666661111",
                Address = "61 Mango Court, Liverpool",
                BusinessName = "IT Services",
                HasLeftReview = true,
                LastReviewDate = DateTime.UtcNow.AddDays(-30)
            },
            new() {
                Name = "Cynthia Olukoya",
                Email = "cynthia@email.com",
                Phone = "07933330000",
                Address = "35 Plum Rise, Luton",
                BusinessName = "Graphic Design",
                HasLeftReview = true,
                LastReviewDate = DateTime.UtcNow.AddDays(-3)
            },
            new() {
                Name = "Jordan Bell",
                Email = "jordan@email.com",
                Phone = "07444449999",
                Address = "88 Grape Yard, Nottingham",
                BusinessName = "Web Development",
                HasLeftReview = false
            },
            new() {
                Name = "Fatima Yusuf",
                Email = "fatima@email.com",
                Phone = "07101010101",
                Address = "13 Avocado Lane, Derby",
                BusinessName = "Digital Marketing",
                HasLeftReview = true,
                LastReviewDate = DateTime.UtcNow.AddDays(-17)
            },
            new() {
                Name = "Dylan Patel",
                Email = "dylan@email.com",
                Phone = "07712312312",
                Address = "2 Lychee Street, Reading",
                BusinessName = "Software Development",
                HasLeftReview = false
            },
            new() {
                Name = "Rhea Kapoor",
                Email = "rhea@email.com",
                Phone = "07333334444",
                Address = "20 Papaya Parade, Milton Keynes",
                BusinessName = "Event Planning",
                HasLeftReview = true,
                LastReviewDate = DateTime.UtcNow.AddDays(-25)
            },
        };

        context.Clients.AddRange(client);

        await context.SaveChangesAsync();
        Console.WriteLine("Database seeded with initial data.");
    }

}
