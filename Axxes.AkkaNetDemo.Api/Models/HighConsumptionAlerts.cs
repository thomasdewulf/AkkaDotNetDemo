using System;
using System.ComponentModel.DataAnnotations;

namespace Axxes.AkkaNetDemo.Api.Models
{
    public class HighConsumptionAlerts
    {
        [Key]
        public Guid DeviceId { get; set; }
        
        public DateTime TimeStamp { get; set; }
        
        public decimal Consumption { get; set; }
        
        public int Duration { get; set; }
    }
}