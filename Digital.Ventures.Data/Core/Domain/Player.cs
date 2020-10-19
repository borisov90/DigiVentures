using System;
using System.ComponentModel.DataAnnotations;

namespace Digital.Ventures.Data.Core.Domain
{
    public class Player
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        public string Country { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
