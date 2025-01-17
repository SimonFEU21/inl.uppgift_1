﻿using System.ComponentModel.DataAnnotations;

namespace WebApi.Models.Entitys
{
    public class StatusEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Status { get; set; } = null!;

        public ICollection<IssueEntity> Issues { get; set; }
    }
}
