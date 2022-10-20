using SelfEmployee.Models.ConfigurationRepositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfEmployee.Models.ViewModels
{
    public class CreateTasksDto
    {
        [Required]
        public string? TaskName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsFlexible { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public string? LocationName { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public string? Details { get; set; }
        public string? Currency { get; set; }
        public decimal? Amount { get; set; }
        public string? TaskStatus { get; set; }
        public List<TaskImage> Images { get; set; }
    }
}
