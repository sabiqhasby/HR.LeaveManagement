using HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Application.Contracts.Persistance;

public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
{
    //biarkan kosong karena sudah Inherit dari class IGenericRepository
}