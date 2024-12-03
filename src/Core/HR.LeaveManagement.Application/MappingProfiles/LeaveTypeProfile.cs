using System;
using AutoMapper;
using HR.LeaveManagement.Application.Features.LeaveType.Querries.GetAllLeaveTypes;
using HR.LeaveManagement.Application.Features.LeaveType.Querries.GetLeaveTypeDetails;
using HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Application.MappingProfiles;

//inherit dari Profile Automapper
public class LeaveTypeProfile : Profile
{
    public LeaveTypeProfile()
    {
        CreateMap<LeaveTypeDto, LeaveType>().ReverseMap();
        CreateMap<LeaveType, LeaveTypeDetailsDto>();
    }
}
