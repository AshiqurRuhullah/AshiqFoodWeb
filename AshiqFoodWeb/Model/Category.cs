﻿using System.ComponentModel.DataAnnotations;

namespace AshiqFoodWeb.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? DisplayOrder { get; set; }
    }
}
