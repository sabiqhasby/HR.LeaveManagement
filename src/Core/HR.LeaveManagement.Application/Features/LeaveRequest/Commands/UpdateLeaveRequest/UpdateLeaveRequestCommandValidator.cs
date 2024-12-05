using System;
using FluentValidation;
using HR.LeaveManagement.Application.Contracts.Persistence;
using HR.LeaveManagement.Application.Features.LeaveRequest.Shared;

namespace HR.LeaveManagement.Application.Features.LeaveRequest.Commands.UpdateLeaveRequest;

public class UpdateLeaveRequestCommandValidator : AbstractValidator<UpdateLeaveRequestCommand>
{
    private readonly ILeaveTypeRepository _leaveTypeRepository;
    private readonly ILeaveRequestRepository _leaveRequestRepository;

    public UpdateLeaveRequestCommandValidator(ILeaveTypeRepository leaveTypeRepository, ILeaveRequestRepository leaveRequestRepository)
    {
        this._leaveTypeRepository = leaveTypeRepository;
        this._leaveRequestRepository = leaveRequestRepository;

        Include(new BaseLeaveRequestValidator(_leaveTypeRepository));

        RuleFor(p => p.Id)
        .NotNull()
        .MustAsync(LeaveRequestMustExist)
        .WithMessage("{PropertyName} must be present");
    }

    private async Task<bool> LeaveRequestMustExist(int id, CancellationToken token)
    {
        var leaveRequest = await _leaveRequestRepository.GetByIdAsync(id);
        return leaveRequest != null;
    }
}
