using System;

namespace Backend_Project.Models
{
    class ReportStoriesFactory : ReportFactory
    {
        private string _header;
        private string _title;
        private string _description;
        private DateTime _published;
        private bool _modified;
        private bool _isExpired;
        private string _authorName;
        private string _imagePath;

        public ReportStoriesFactory(string Header, string Title, string Description, DateTime Published, bool Modified, bool IsExpired, string AuthorName, string ImagePath)
        {
            _header = Header;
            _title = Title;
            _description = Description;
            _published = Published;
            _modified = Modified;
            _isExpired = IsExpired;
            _authorName = AuthorName;
            _imagePath = ImagePath;
        }
        public override Report GetReportType()
        {
            return new ReportStories(_header, _title, _description, _published, _modified, _isExpired, _authorName, _imagePath);
        }
    }
}