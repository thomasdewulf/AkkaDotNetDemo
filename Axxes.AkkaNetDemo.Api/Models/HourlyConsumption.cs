using System;
using System.ComponentModel.DataAnnotations;

namespace Axxes.AkkaNetDemo.Api.Models
{
    public class HourlyConsumption
    {
        [Key]
        public Guid DeviceId { get; set; }
        
        public DateTime Timestamp { get; set; }
        
        public decimal Consumption { get; set; }
        
        public string Unit { get; set; }
    }
}