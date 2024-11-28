﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Slider : BaseEntity
    {
        [MaxLength(32)]
        public string Title { get; set; } = null!;

        [MaxLength(64)]
        public string Subtitle { get; set; } = null!;

        public string? Link { get; set; }

        public string ImageUrl { get; set; } = null!;
    }
}
