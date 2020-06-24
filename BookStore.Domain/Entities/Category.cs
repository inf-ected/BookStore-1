﻿using System.Collections.Generic;

namespace BookStore.Domain.Entities
{
    public class Category
    {   // Disable autoincrement for primary key
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        //[Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}