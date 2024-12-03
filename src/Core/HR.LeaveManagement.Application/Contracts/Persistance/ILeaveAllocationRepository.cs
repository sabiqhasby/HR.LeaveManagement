using HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Application.Contracts.Persistance;

public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
{
    //biarkan kosong karena sudah Inherit dari class IGenericRepository
}
