using System;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Querries.GetAllLeaveTypes;

// public class GetLeaveTypesQuery : IRequest<List<LeaveTypeDto>>
// {

// }
public record GetLeaveTypesQuery : IRequest<List<LeaveTypeDto>>;

