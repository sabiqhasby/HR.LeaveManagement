using System;
using AutoMapper;
using HR.LeaveManagement.Application.Contracts.Persistance;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Commands.DeleteLeaveType;

public class DeleteLeaveTypeCommandHandler : IRequestHandler<DeleteLeaveTypeCommand, Unit>
{

    private readonly ILeaveTypeRepository _leaveTypeRepository;

    public DeleteLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository)
    {
        this._leaveTypeRepository = leaveTypeRepository;
    }
    public async Task<Unit> Handle(DeleteLeaveTypeCommand request, CancellationToken cancellationToken)
    {
        //retrieve domaim entity object
        var leaveTypeToDelete = await _leaveTypeRepository.GetByIdAsync(request.Id);

        //verify that record is exist
        // if (leaveTypeToDelete == null)
        // {

        // }

        //remove from Database
        await _leaveTypeRepository.DeleteAsync(leaveTypeToDelete);

        //return something
        return Unit.Value;
    }
}
