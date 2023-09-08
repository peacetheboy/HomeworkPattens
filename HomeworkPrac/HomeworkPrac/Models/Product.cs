﻿using System;
using System.Collections.Generic;

namespace HomeworkPrac.Models
{
    public partial class Product
    {
        public Guid ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
