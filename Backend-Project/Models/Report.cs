using System;
using System.ComponentModel.DataAnnotations;

namespace Backend_Project.Models
{
    public abstract class Report
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public abstract string ReportType { get;}
        [Required]
        public abstract string Header { get; set; }
        [Required]
        public abstract string Title { get; set; }
        [Required]
        public abstract string Description { get; set; }
        [Required]
        public abstract DateTime Published { get; set; }
        [Required]
        public abstract bool Modified {get; set;}
        [Required]
        public abstract bool IsExpired { get; set; }
        [Required]
        public abstract string AuthorName {get;set;}
    }
}