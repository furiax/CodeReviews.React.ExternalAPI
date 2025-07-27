using System.ComponentModel.DataAnnotations;

namespace FormulaOneServer.Models
{
    public class Driver
    {
        public int Id { get; set; } 
        public int DriverNumber { get; set; }
        public string DriverName { get; set; }
        public string DriverImageLink { get; set; }
        public string Team { get; set; }
        public string CarImageLink { get; set; }
        public string Country { get; set; }
        public int NumberOfGPs { get; set; }
        public int WorldChampionships { get; set; }
        public string Helmet { get; set; }
    }
}
