using System;

namespace Backend_Project.Models
{
    class ReportHealth : Report
    {
        private string _reportType;
        private string _header;
        private string _title;
        private string _description;
        private DateTime _published;
        private bool _modified;
        private bool _isExpired;
        private string _authorName;
        public ReportHealth(string Header, string Title, string Description, DateTime Published, bool Modified, bool IsExpired, string AuthorName)
        {
            _reportType = "Health";
            _header = Header;
            _title = Title;
            _description = Description;
            _published = Published;
            _modified = Modified;
            _isExpired = IsExpired;
            _authorName = AuthorName;
        }

        public string ReportType { get => _reportType; set => _reportType = value; }
        public DateTime Published { get => _published; set => _published = value; }
        public bool Modified { get => _modified; set => _modified = value; }
        public bool IsExpired { get => _isExpired; set => _isExpired = value; }
        public string AuthorName { get => _authorName; set => _authorName = value; }
        public string Header { get => _header; set => _header = value; }
        public string Title { get => _title; set => _title = value; }
        public string Description { get => _description; set => _description = value; }
    }
}