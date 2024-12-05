using System;
using AutoMapper;
using HR.LeaveManagement.Application.Contracts.Persistence;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveRequest.Queries.GetLeaveRequestList;

public class GetLeaveRequestListQueryHandler : IRequestHandler<GetLeaveRequestListQuery, List<LeaveRequestListDto>>
{
    private readonly IMapper _mapper;
    private readonly ILeaveRequestRepository _leaveRequestRepository;

    public GetLeaveRequestListQueryHandler(IMapper mapper, ILeaveRequestRepository leaveRequestRepository)
    {
        this._mapper = mapper;
        this._leaveRequestRepository = leaveRequestRepository;
    }

    public async Task<List<LeaveRequestListDto>> Handle(GetLeaveRequestListQuery request, CancellationToken cancellationToken)
    {
        //check if it is logged in employee
        var leaveRequestList = await _leaveRequestRepository.GetAsync();

        var data = _mapper.Map<List<LeaveRequestListDto>>(leaveRequestList);
        //Fill Request with employee information
        return data;
    }
}
