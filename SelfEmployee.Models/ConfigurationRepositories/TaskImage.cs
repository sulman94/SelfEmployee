using System;
using System.Collections.Generic;

namespace SelfEmployee.Models.ConfigurationRepositories
{
    public partial class TaskImage
    {
        public long Id { get; set; }
        public string? ImageBase64 { get; set; }
        public long? TaskId { get; set; }

        public virtual Tasks? ParentTask { get; set; }
    }
}
