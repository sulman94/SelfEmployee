using System;
using System.Collections.Generic;

namespace SelfEmployee.Models.ConfigurationRepositories
{
    public partial class Tasks
    {
        public Tasks()
        {
            TaskImages = new HashSet<TaskImage>();
        }

        public long Id { get; set; }
        public string? TaskName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? IsFlexible { get; set; }
        public int? CategoryId { get; set; }
        public string? LocationName { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public string? Details { get; set; }
        public string? Currency { get; set; }
        public decimal? Amount { get; set; }
        public string? TaskStatus { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual TaskCategory? Category { get; set; }
        public virtual ICollection<TaskImage> TaskImages { get; set; }
    }
}
