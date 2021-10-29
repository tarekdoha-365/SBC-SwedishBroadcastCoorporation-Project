using System;

namespace Backend_Project.Models
{
    class ReportStories: Report
    {
        private readonly string _reportType;
        private string _header;
        private string _title;
        private string _description;
        private DateTime _published;
        private bool _modified;
        private bool _isExpired;
        private string _authorName;
        public ReportStories(string Header, string Title, string Description, DateTime Published, bool Modified, bool IsExpired, string AuthorName)
        {
            _reportType = "Business";
            _header = Header;
            _title = Title;
            _description = Description;
            _published = Published;
            _modified = Modified;
            _isExpired = IsExpired;
            _authorName = AuthorName;
        }

        public override string ReportType { get => _reportType; }
        public override DateTime Published { get => _published; set => _published = value; }
        public override bool Modified { get => _modified; set => _modified = value; }
        public override bool IsExpired { get => _isExpired; set => _isExpired = value; }
        public override string AuthorName { get => _authorName; set => _authorName = value; }
        public override string Header { get => _header; set => _header = value; }
        public override string Title { get => _title; set => _title = value; }
        public override string Description { get => _description; set => _description = value; }
    }
}