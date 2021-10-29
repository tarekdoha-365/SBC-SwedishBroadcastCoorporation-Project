using System.Collections.Generic;
using System.Linq;
using Backend_Project.Data;
using Backend_Project.Interfaces;
using Backend_Project.Models;

namespace Backend_Project.Services
{
    public class ReportRepository : IReport
    {
        private readonly AppDbContext _context;

        public ReportRepository(AppDbContext context)
        {
            _context = context;
        }
        public Report CreateReport(Report report)
        {
            throw new System.NotImplementedException();
        }

        public int DeleteReport(Report report)
        {
            throw new System.NotImplementedException();
        }

        public Report GetReportById(int Id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Report> GetReports(string reportType)
        {
            ReportFactory reportFactory=null;
            Report report=null;
            switch(reportType.ToLower())
            {
                case "Business":
                reportFactory = new ReportBussinessFactory(report.Header, report.Title, report.Description, report.Published, report.Modified, report.IsExpired, report.AuthorName);
                report = reportFactory.GetReportType();
                break;
                case "Climate":
                reportFactory = new ReportClimateFactory(report.Header, report.Title,report.Description, report.Published, report.Modified, report.IsExpired, report.AuthorName);
                break;
                default:
                break;
            }
            var result = _context.Reports.ToList().Where(x => x.ReportType == reportType);
            return result;
        }

        public void SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public Report UpdateReport(Report report)
        {
            throw new System.NotImplementedException();
        }
    }
}