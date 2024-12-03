using System;
using AutoMapper;
using HR.LeaveManagement.Application.Contracts.Persistance;
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
        var data = _mapper.Map<List<LeaveTypeDto>>(leaveTypes);
        //Convert data Objects to DTO objects

        //return list of DTO objects
        return data;
    }
}
