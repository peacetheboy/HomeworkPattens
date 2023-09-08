using System;
using System.Collections.Generic;

namespace HomeworkPrac.Models
{
    public partial class Service
    {
        public Guid ServiceId { get; set; }
        public string ServiceName { get; set; } = null!;
        public string ServiceDescription { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
    }
}
