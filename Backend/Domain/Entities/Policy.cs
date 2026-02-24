using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NewBI.Backend.Domain.Entities
{
    public class Policy
    {
        [Key]
        public Guid Id { get; set; }
        
        [Required]
        public string PolicyNumber { get; set; }
        
        [Required]
        public string InsuredName { get; set; }
        
        [Required]
        public DateTime StartDate { get; set; }
        
        [Required]
        public DateTime EndDate { get; set; }
        
        [Required]
        public decimal PremiumAmount { get; set; }
        
        public string Status { get; set; }
        
        public virtual ICollection<Claim> Claims { get; set; }
    }
}