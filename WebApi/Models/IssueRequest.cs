﻿using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class IssueRequest
    {
    

        [Required]
        public string Subject { get; set; }

        [Required]
        public string Description { get; set; }
     
        [Required]
        public int CustomerId { get; set; }
    }
}
