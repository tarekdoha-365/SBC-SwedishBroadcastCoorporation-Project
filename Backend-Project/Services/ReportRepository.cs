using System;
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
            if (report == null)
            {
                throw new ArgumentNullException(nameof(Report));
            }
            _context.Add(report);
            SaveChanges();
            return report;
        }
        public Report DeleteReport(int id)
        {
            var item = _context.Reports.FirstOrDefault(x => x.Id == id);
            if (GetReportById(id) != null)
            {
                _context.Remove(item);
                SaveChanges();
                return item;
            }
            return item;
        }

        public Report GetReportById(int Id)
        {
            return _context.Reports.FirstOrDefault(x => x.Id == Id) ;
        }
        public IEnumerable<Report> GetReports(string reportType)
        {
            return _context.Reports.ToList().Where(x => x.ReportType == reportType);
        }
        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0);
        }

        public Report UpdateReport(Report report)
        {
            var existingReport = _context.Reports.Where(x => x.Id.Equals(report.Id)).FirstOrDefault();
            if (existingReport!=null)
            {
                existingReport.Id = report.Id;
                existingReport.ReportType = report.ReportType;
                existingReport.Header = report.Header;
                existingReport.Title = report.Title;
                existingReport.Description = report.Description;
                existingReport.Published = report.Published;
                existingReport.Modified = report.Modified;
                existingReport.IsExpired = report.IsExpired;
                existingReport.AuthorName = report.AuthorName;
                existingReport.ImagePath = report.ImagePath;
                _context.Update(existingReport);
                SaveChanges();
                return existingReport;
            }
            throw new Exception($"Report Id could not be found: {report.Id}");
        }
    }
}