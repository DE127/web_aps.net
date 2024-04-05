﻿using System;
using System.Collections.Generic;

namespace web_aps.net.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public byte? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Image { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
