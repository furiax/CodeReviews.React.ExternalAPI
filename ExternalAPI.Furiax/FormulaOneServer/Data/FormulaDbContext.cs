using FormulaOneServer.Models;
using Microsoft.EntityFrameworkCore;

namespace FormulaOneServer.Data;
public class FormulaDbContext : DbContext
{
    public FormulaDbContext(DbContextOptions options) : base(options)
    {

    }
    public DbSet<Driver> Drivers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Driver>().HasData(
            new Driver
            {
                Id = 1,
                DriverNumber = 1,
                DriverName = "Max Verstappen",
                DriverImageLink = "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2025Drivers/verstappen",
                Team = "Red Bull Racing",
                CarImageLink = "https://media.formula1.com/d_team_car_fallback_image.png/content/dam/fom-website/teams/2025/red-bull-racing.png",
                Country = "Netherlands",
                NumberOfGPs = 213,
                WorldChampionships = 4,
                Helmet = "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1024/fom-website/manual/Helmets2025/verstappen"
            },
            new Driver
            {
                Id = 2,
                DriverNumber = 22,
                DriverName = "Yuki Tsunoda",
                DriverImageLink = "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2025Drivers/tsunoda",
                Team = "Red Bull Racing",
                CarImageLink = "https://media.formula1.com/d_team_car_fallback_image.png/content/dam/fom-website/teams/2025/red-bull-racing.png",
                Country = "Japan",
                NumberOfGPs = 91,
                WorldChampionships = 0,
                Helmet = "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1024/fom-website/manual/Helmets2025/tsunoda"
            },
            new Driver
            {
                Id = 3,
                DriverNumber = 16,
                DriverName = "Charles Leclerc",
                DriverImageLink = "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2025Drivers/leclerc",
                Team = "Ferrari",
                CarImageLink = "https://media.formula1.com/d_team_car_fallback_image.png/content/dam/fom-website/teams/2025/ferrari.png",
                Country = "Monaco",
                NumberOfGPs = 151,
                WorldChampionships = 0,
                Helmet = "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1024/fom-website/manual/Helmets2025/leclerc"
            },
            new Driver
            {
                Id = 4,
                DriverNumber = 44,
                DriverName = "Lewis Hamilton",
                DriverImageLink = "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/drivers/2025Drivers/hamilton",
                Team = "Ferrari",
                CarImageLink = "https://media.formula1.com/d_team_car_fallback_image.png/content/dam/fom-website/teams/2025/ferrari.png",
                Country = "United Kingdom",
                NumberOfGPs = 360,
                WorldChampionships = 7,
                Helmet = "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1024/fom-website/manual/Helmets2025/hamilton"
            },
            new Driver
            {
                Id = 5,
                DriverNumber = 81,
                DriverName = "Oscar Piastri",
                DriverImageLink = "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2025Drivers/piastri",
                Team = "McLaren",
                CarImageLink = "https://media.formula1.com/d_team_car_fallback_image.png/content/dam/fom-website/teams/2025/mclaren.png",
                Country = "Australia",
                NumberOfGPs = 50,
                WorldChampionships = 0,
                Helmet = "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1024/fom-website/manual/Helmets2025/piastri"
            },
            new Driver
            {
                Id = 6,
                DriverNumber = 4,
                DriverName = "Lando Norris",
                DriverImageLink = "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2025Drivers/norris",
                Team = "McLaren",
                CarImageLink = "https://media.formula1.com/d_team_car_fallback_image.png/content/dam/fom-website/teams/2025/mclaren.png",
                Country = "United Kingdom",
                NumberOfGPs = 132,
                WorldChampionships = 0,
                Helmet = "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1024/fom-website/manual/Helmets2025/norris"
            },
            new Driver
            {
                Id = 7,
                DriverNumber = 63,
                DriverName = "George Russel",
                DriverImageLink = "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2025Drivers/russell",
                Team = "Mercedes",
                CarImageLink = "https://media.formula1.com/d_team_car_fallback_image.png/content/dam/fom-website/teams/2025/mercedes.png",
                Country = "United Kingdom",
                NumberOfGPs = 132,
                WorldChampionships = 0,
                Helmet = "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1024/fom-website/manual/Helmets2025/russell"
            },
            new Driver
            {
                Id = 8,
                DriverNumber = 12,
                DriverName = "Andrea Kimi Antoneli",
                DriverImageLink = "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/drivers/2025Drivers/antonelli",
                Team = "Mercedes",
                CarImageLink = "https://media.formula1.com/d_team_car_fallback_image.png/content/dam/fom-website/teams/2025/mercedes.png",
                Country = "Italy",
                NumberOfGPs = 4,
                WorldChampionships = 0,
                Helmet = "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1024/fom-website/manual/Helmets2025/antonelli"
            },
            new Driver
            {
                Id = 9,
                DriverNumber = 18,
                DriverName = "Lance Stroll",
                DriverImageLink = "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/drivers/2025Drivers/stroll",
                Team = "Aston Martin",
                CarImageLink = "https://media.formula1.com/d_team_car_fallback_image.png/content/dam/fom-website/teams/2025/aston-martin.png",
                Country = "Canada",
                NumberOfGPs = 170,
                WorldChampionships = 0,
                Helmet = "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1024/fom-website/manual/Helmets2025/stroll"
            },
            new Driver
            {
                Id = 10,
                DriverNumber = 14,
                DriverName = "Fernando Alonso",
                DriverImageLink = "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2025Drivers/alonso",
                Team = "Aston Martin",
                CarImageLink = "https://media.formula1.com/d_team_car_fallback_image.png/content/dam/fom-website/teams/2025/aston-martin.png",
                Country = "Spain",
                NumberOfGPs = 407,
                WorldChampionships = 2,
                Helmet = "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1024/fom-website/manual/Helmets2025/alonso"
            },
            new Driver
            {
                Id = 11,
                DriverNumber = 23,
                DriverName = "Alexander Albon",
                DriverImageLink = "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2025Drivers/albon",
                Team = "Williams",
                CarImageLink = "https://media.formula1.com/d_team_car_fallback_image.png/content/dam/fom-website/teams/2025/williams.png",
                Country = "Thailand",
                NumberOfGPs = 108,
                WorldChampionships = 0,
                Helmet = "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1024/fom-website/manual/Helmets2025/albon"
            },
            new Driver
            {
                Id = 12,
                DriverNumber = 55,
                DriverName = "Carlos Sainz",
                DriverImageLink = "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/drivers/2025Drivers/sainz",
                Team = "Williams",
                CarImageLink = "https://media.formula1.com/d_team_car_fallback_image.png/content/dam/fom-website/teams/2025/williams.png",
                Country = "Spain",
                NumberOfGPs = 210,
                WorldChampionships = 0,
                Helmet = "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1024/fom-website/manual/Helmets2025/sainz"
            },
            new Driver
            {
                Id = 13,
                DriverNumber = 10,
                DriverName = "Pierre Gasly",
                DriverImageLink = "https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2025Drivers/gasly",
                Team = "Alpine",
                CarImageLink = "https://media.formula1.com/d_team_car_fallback_image.png/content/dam/fom-website/teams/2025/alpine.png",
                Country = "France",
                NumberOfGPs = 157,
                WorldChampionships = 0,
                Helmet = "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1024/fom-website/manual/Helmets2025/gasly"
            },
            new Driver
            {
                Id = 14,
                DriverNumber = 7,
                DriverName = "Jack Doohan",
                DriverImageLink = "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/drivers/2025Drivers/doohan",
                Team = "Alpine",
                CarImageLink = "https://media.formula1.com/d_team_car_fallback_image.png/content/dam/fom-website/teams/2025/alpine.png",
                Country = "Australia",
                NumberOfGPs = 5,
                WorldChampionships = 0,
                Helmet = "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1024/fom-website/manual/Helmets2025/doohan"
            },
            new Driver
            {
                Id = 15,
                DriverNumber = 31,
                DriverName = "Esteban Ocon",
                DriverImageLink = "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/drivers/2025Drivers/ocon",
                Team = "Haas",
                CarImageLink = "https://media.formula1.com/d_team_car_fallback_image.png/content/dam/fom-website/teams/2025/haas.png",
                Country = "France",
                NumberOfGPs = 160,
                WorldChampionships = 0,
                Helmet = "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1024/fom-website/manual/Helmets2025/ocon"
            },
            new Driver
            {
                Id = 16,
                DriverNumber = 87,
                DriverName = "Oliver Bearman",
                DriverImageLink = "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/drivers/2025Drivers/bearman",
                Team = "Haas",
                CarImageLink = "https://media.formula1.com/d_team_car_fallback_image.png/content/dam/fom-website/teams/2025/haas.png",
                Country = "United Kingdom",
                NumberOfGPs = 7,
                WorldChampionships = 0,
                Helmet = "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1024/fom-website/manual/Helmets2025/bearman"
            },
            new Driver
            {
                Id = 17,
                DriverNumber = 27,
                DriverName = "Nico Hulkenberg",
                DriverImageLink = "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/drivers/2025Drivers/hulkenberg",
                Team = "Kick Sauber",
                CarImageLink = "https://media.formula1.com/d_team_car_fallback_image.png/content/dam/fom-website/teams/2025/kick-sauber.png",
                Country = "Germany",
                NumberOfGPs = 231,
                WorldChampionships = 0,
                Helmet = "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1024/fom-website/manual/Helmets2025/hulkenberg"
            },
            new Driver
            {
                Id = 18,
                DriverNumber = 5,
                DriverName = "Gabriel Bortoleto",
                DriverImageLink = "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/drivers/2025Drivers/bortoleto",
                Team = "Kick Sauber",
                CarImageLink = "https://media.formula1.com/d_team_car_fallback_image.png/content/dam/fom-website/teams/2025/kick-sauber.png",
                Country = "Brazil",
                NumberOfGPs = 4,
                WorldChampionships = 0,
                Helmet = "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1024/fom-website/manual/Helmets2025/bortoleto"
            },
            new Driver
            {
                Id = 19,
                DriverNumber = 6,
                DriverName = "Isack Hadjar",
                DriverImageLink = "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/drivers/2025Drivers/hadjar",
                Team = "Racing Bulls",
                CarImageLink = "https://media.formula1.com/d_team_car_fallback_image.png/content/dam/fom-website/teams/2025/racing-bulls.png",
                Country = "France",
                NumberOfGPs = 4,
                WorldChampionships = 0,
                Helmet = "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1024/fom-website/manual/Helmets2025/hadjar"
            },
            new Driver
            {
                Id = 20,
                DriverNumber = 30,
                DriverName = "Liam Lawson",
                DriverImageLink = "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/drivers/2025Drivers/lawson",
                Team = "Racing Bulls",
                CarImageLink = "https://media.formula1.com/d_team_car_fallback_image.png/content/dam/fom-website/teams/2025/racing-bulls.png",
                Country = "New Zealand",
                NumberOfGPs = 15,
                WorldChampionships = 0,
                Helmet = "https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1024/fom-website/manual/Helmets2025/lawson"
            }
        );
    }
}
