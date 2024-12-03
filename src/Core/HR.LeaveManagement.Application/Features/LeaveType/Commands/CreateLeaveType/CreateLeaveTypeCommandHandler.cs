using System;
using AutoMapper;
using HR.LeaveManagement.Application.Contracts.Persistance;
using HR.LeaveManagement.Application.Exceptions;
using MediatR;
using static HR.LeaveManagement.Application.Exceptions.NotFoundException;

namespace HR.LeaveManagement.Application.Features.LeaveType.Commands.CreateLeaveType;

public class CreateLeaveTypeCommandHandler : IRequestHandler<CreateLeaveTypeCommand, int>
{
    private readonly IMapper _mapper;
    private readonly ILeaveTypeRepository _leaveTypeRepository;

    public CreateLeaveTypeCommandHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
    {
        this._mapper = mapper;
        this._leaveTypeRepository = leaveTypeRepository;
    }
    public async Task<int> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken)
    {
        //Validate Incoming Data
        var validator = new CreateLeaveTypeCommandValidator(_leaveTypeRepository);
        var validationResult = await validator.ValidateAsync(request);
        //Convert to domain entity object
        var leaveTypeToCreate = _mapper.Map<Domain.LeaveType>(request);

        if (validationResult.Errors.Any())
        {
            throw new BadRequestException("Invalid LeaveType", validationResult);
        }

        // add to database
        await _leaveTypeRepository.CreateAsync(leaveTypeToCreate);

        // return record id
        return leaveTypeToCreate.Id;
    }
}
