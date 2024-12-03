using HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Application.Contracts.Persistance;

public interface ILeaveTypeRepository : IGenericRepository<LeaveType>
{
    //biarkan kosong karena sudah Inherit dari class IGenericRepository
}
