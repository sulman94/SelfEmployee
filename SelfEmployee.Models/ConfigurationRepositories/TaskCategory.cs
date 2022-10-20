using System;
using System.Collections.Generic;

namespace SelfEmployee.Models.ConfigurationRepositories
{
    public partial class TaskCategory
    {
        public TaskCategory()
        {
            TasksCollection = new HashSet<Tasks>();
        }

        public int Id { get; set; }
        public string? CategoryName { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Tasks> TasksCollection { get; set; }
    }
}
