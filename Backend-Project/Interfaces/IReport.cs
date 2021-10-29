using System.Collections.Generic;
using Backend_Project.Models;

namespace Backend_Project.Interfaces
{
    public interface IReport
    {
       IEnumerable<Report> GetReports(string reportType);
       Report GetReportById(int Id);
       int DeleteReport(Report report);
       Report CreateReport (Report report);
       void SaveChanges();
       Report UpdateReport (Report report);

    }
}