using System;

namespace Backend_Project.Models
{
    class ReportEntertainmentAndArt: Report
    {
        private string _reportType;
        private string _header;
        private string _title;
        private string _description;
        private DateTime _published;
        private bool _modified;
        private bool _isExpired;
        private string _authorName;
        private string _imagePath;
        public ReportEntertainmentAndArt(string Header, string Title, string Description, DateTime Published, bool Modified, bool IsExpired, string AuthorName, string ImagePath)
        {
            _reportType = "EntertainmentAndArt";
            _header = Header;
            _title = Title;
            _description = Description;
            _published = Published;
            _modified = Modified;
            _isExpired = IsExpired;
            _authorName = AuthorName;
            _imagePath = ImagePath;
        }
    }
}