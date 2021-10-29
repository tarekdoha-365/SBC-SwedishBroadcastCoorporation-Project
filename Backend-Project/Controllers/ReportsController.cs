using System.Collections.Generic;
using AutoMapper;
using Backend_Project.Dtos;
using Backend_Project.Interfaces;
using Backend_Project.Services;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Project.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ReportsController: ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IReport _reportRepo;

        public ReportsController( IReport reportRepo, IMapper mapper)
        {
            _reportRepo = reportRepo;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult <IEnumerable<ReportReadDtos>> GetReports(string reportType)
        {
            var reports = _reportRepo.GetReports(reportType);
             return Ok(_mapper.Map<IEnumerable<ReportReadDtos>>(reports));
        }
    }
}