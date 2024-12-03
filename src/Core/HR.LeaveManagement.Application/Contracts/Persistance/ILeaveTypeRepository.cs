using HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Application.Contracts.Persistance;

public interface ILeaveTypeRepository : IGenericRepository<LeaveType>
{
    //sisanya ada di IGenericRepository karena ini inherit
    Task<bool> IsLeaveTypeUnique(string name);
    // Task<bool> LeaveMustExist(int id);

}
