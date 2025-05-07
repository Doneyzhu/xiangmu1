using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace xiangmu.Models
{
    public class Positions
    {
        [Key]
        public int PositionId { get; set; }
        public string PositionName { get; set; }
        public string Department { get; set; }
        public string Description { get; set; }
    }
}
