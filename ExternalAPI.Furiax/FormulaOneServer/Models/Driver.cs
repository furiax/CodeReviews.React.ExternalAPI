using System.ComponentModel.DataAnnotations;

namespace FormulaOneServer.Models
{
    public class Driver
    {
        [Key]
        public int DriverNumber { get; set; }
        public string DriverName { get; set; }
        public string DriverImageLink { get; set; }
        public string Team { get; set; }
        public string CarImageLink { get; set; }
    }
}
