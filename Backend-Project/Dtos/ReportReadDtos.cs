using System;

namespace Backend_Project.Dtos
{
    public class ReportReadDtos
    {
        public int Id { get; set; }
        public string ReportType { get; set; }
        public string Header { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Published { get; set; }
        public bool Modified {get; set;}
        public bool IsExpired { get; set; }
        public string AuthorName {get;set;}
        public string ImagePath { get; set; }
    }
}