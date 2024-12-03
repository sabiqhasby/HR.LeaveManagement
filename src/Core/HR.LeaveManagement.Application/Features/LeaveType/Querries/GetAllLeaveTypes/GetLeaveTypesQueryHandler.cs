using System;
using AutoMapper;
using HR.LeaveManagement.Application.Contracts.Persistance;
using HR.LeaveManagement.Application.Exceptions;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Querries.GetAllLeaveTypes;

//IRequestHandle<theRequest, theResponse>
public class GetLeaveTypesQueryHandler : IRequestHandler<GetLeaveTypesQuery, List<LeaveTypeDto>>
{
    private readonly IMapper _mapper;
    private readonly ILeaveTypeRepository _leaveTypeRepository;
    public GetLeaveTypesQueryHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
    {
        this._mapper = mapper;
        this._leaveTypeRepository = leaveTypeRepository;
    }
    public async Task<List<LeaveTypeDto>> Handle(GetLeaveTypesQuery request, CancellationToken cancellationToken)
    {
        //query the Database
        var leaveTypes = await _leaveTypeRepository.GetAsync();
        //Convert data Objects to DTO objects
        var data = _mapper.Map<List<LeaveTypeDto>>(leaveTypes);

        //verify that record is not exist
        if (leaveTypes == null)
        {
            throw new Exception();
        }
        //return list of DTO objects
        return data;
    }
}
