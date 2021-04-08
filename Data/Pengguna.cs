using System;
using System.ComponentModel.DataAnnotations;

namespace AldesApp.Data
{
    public class Tamu
    {
            [Required]
            [StringLength(10, ErrorMessage = "Name is too long.")]
            public string Name { get; set; }
            
            [Required]
            [StringLength(10, ErrorMessage = "Format Email Salah")]
            public string Email { get; set; }
        
    }
}