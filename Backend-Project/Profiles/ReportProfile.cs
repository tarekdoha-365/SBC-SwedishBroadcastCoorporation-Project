using AutoMapper;
using Backend_Project.Dtos;
using Backend_Project.Interfaces;
using Backend_Project.Models;

namespace Backend_Project.Profiles
{
    public class ReportProfile : Profile
    {
        public ReportProfile()
        {
            CreateMap<Report, ReportReadDtos>();
            CreateMap<ReportCreateDtos, Report>();
        }
    }
    
}