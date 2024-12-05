using System;
using FluentValidation;

namespace HR.LeaveManagement.Application.Features.LeaveRequest.Commands.ChangeLeaveRequestApproval;

public class ChangeLeaveRequestCommandValidator : AbstractValidator<ChangeLeaveRequestApprovalCommand>
{
    public ChangeLeaveRequestCommandValidator()
    {
        RuleFor(p => p.Approved).NotNull().WithMessage("Approval Status Cant Be null");
    }
}
