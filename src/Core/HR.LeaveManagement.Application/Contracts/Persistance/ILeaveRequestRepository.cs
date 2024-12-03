using HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Application.Contracts.Persistance;

public interface ILeaveRequestRepository<T> : IGenericRepository<LeaveRequest>
{
    //biarkan kosong karena sudah Inherit dari class IGenericRepository
}