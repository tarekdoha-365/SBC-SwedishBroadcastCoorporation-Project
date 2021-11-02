using System.Collections.Generic;
using Backend_Project.Models;

namespace Backend_Project.Interfaces
{
    public interface IReport
    {
       IEnumerable<Report> GetReports(string reportType);
       Report GetReportById(int Id);
       Report DeleteReport(int id);
       Report CreateReport (Report report);
       bool SaveChanges();
       Report UpdateReport (Report report);
    }
}