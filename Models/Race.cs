﻿using Fitness_Web.Data.Enum;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Fitness_Web.Models
{
    public class Race
    {
        [Key]
        public int Id { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public string? Image { get; set; }
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address? Address { get; set; }

        public RaceCategory RaceCategory { get; set; }
        [ForeignKey("AppUser")]
        public string? Appuserid { get; set; }
        public AppUser? Appuser { get; set; }
    }
}
