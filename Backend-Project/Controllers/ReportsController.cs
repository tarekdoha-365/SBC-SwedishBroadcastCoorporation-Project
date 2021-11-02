using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Backend_Project.Dtos;
using Backend_Project.Interfaces;
using Backend_Project.Models;
using Backend_Project.Services;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Project.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IReport _reportRepo;

        public ReportsController(IReport reportRepo, IMapper mapper)
        {
            _reportRepo = reportRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ReportReadDtos>> GetReports(string reportType)
        {
            var reports = _reportRepo.GetReports(reportType);
            return Ok(_mapper.Map<IEnumerable<ReportReadDtos>>(reports));
        }

        [HttpGet("{id}", Name = "GetReportById")]
        public ActionResult <ReportReadDtos> GetReportById(int id)
        {
            var reportItem = _reportRepo.GetReportById(id);
            if (reportItem != null)
            {
                return Ok(_mapper.Map<ReportReadDtos>(reportItem));  
            }
            return NotFound();
        }
        [HttpDelete]
        public ActionResult <ReportReadDtos> DeleteReport(int id)
        {
            if(GetReportById(id)!=null)
            {
                var deleteReport = _reportRepo.DeleteReport(id);
                return Ok(_mapper.Map<ReportReadDtos>(deleteReport));
            }
            return NotFound();
        }
        [HttpPost]
        public ActionResult<ReportReadDtos> CreateReport(ReportCreateDtos reportCreateDtos)
        {

            var reportModel = _mapper.Map<Report>(reportCreateDtos);
            var createReport = _reportRepo.CreateReport(reportModel);
            _reportRepo.SaveChanges();
            var reportReadDtos = _mapper.Map<ReportReadDtos>(reportModel);
            return CreatedAtRoute(nameof(GetReportById), new { Id = reportReadDtos.Id }, reportReadDtos);
        }
        [HttpPut]
        public ActionResult<ReportReadDtos> UpdateReport(ReportUpdateDtos reportUpdateDtos)
        {
            var reportModel = _mapper.Map<Report>(reportUpdateDtos);
            var updateReport = _reportRepo.UpdateReport(reportModel);
            _reportRepo.SaveChanges();
            var reportReadDtos = _mapper.Map<ReportReadDtos>(reportModel);
            return Ok(_mapper.Map<ReportReadDtos>(updateReport));
        }
    }
}