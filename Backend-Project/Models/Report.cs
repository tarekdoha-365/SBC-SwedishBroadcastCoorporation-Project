using Backend_Project.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_Project.Models
{
    public class Report
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ReportType { get; set; }
        [Required]
        public string Header { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime Published { get; set; }
        [Required]
        public bool Modified { get; set; }
        [Required]
        public bool IsExpired { get; set; }
        [Required]
        public string AuthorName { get; set; }
        [Required]
        public string ImagePath { get; set; }
    }
}