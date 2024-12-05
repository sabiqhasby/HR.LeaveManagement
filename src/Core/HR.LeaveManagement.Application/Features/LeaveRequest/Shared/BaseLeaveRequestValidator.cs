using System;
using FluentValidation;
using HR.LeaveManagement.Application.Contracts.Persistence;

namespace HR.LeaveManagement.Application.Features.LeaveRequest.Shared;

public class BaseLeaveRequestValidator : AbstractValidator<BaseLeaveRequest>
{

    private ILeaveTypeRepository _leaveTypeRepository;

    public BaseLeaveRequestValidator(ILeaveTypeRepository leaveTypeRepository)
    {
        this._leaveTypeRepository = leaveTypeRepository;

        RuleFor(p => p.StartDate)
        .LessThan(p => p.EndDate).WithMessage("{PropertyName} must before {ComparisonValue}");

        RuleFor(p => p.EndDate)
        .GreaterThan(p => p.StartDate).WithMessage("{PropertyName} must after {ComparisonValue}");

        RuleFor(p => p.LeaveTypeId)
        .GreaterThan(0)
        .MustAsync(LeaveTypeMustExist)
        .WithMessage("{PropertyName} does not exist");
    }



    private async Task<bool> LeaveTypeMustExist(int id, CancellationToken arg2)
    {
        var leaveType = await _leaveTypeRepository.GetByIdAsync(id);
        return leaveType != null;
    }
}
