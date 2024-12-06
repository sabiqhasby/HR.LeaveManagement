using System;
using AutoMapper;
using HR.LeaveManagement.UI.Models.LeaveTypes;
using HR.LeaveManagement.UI.Services.Base;

namespace HR.LeaveManagement.UI.Contracts.MappingProfiles;

public class MappingConfig : Profile
{
    public MappingConfig()
    {
        CreateMap<LeaveTypeDto, LeaveTypeVM>().ReverseMap();
        CreateMap<CreateLeaveTypeCommand, LeaveTypeVM>().ReverseMap();
        CreateMap<UpdateLeaveTypeCommand, LeaveTypeVM>().ReverseMap();

    }
}
