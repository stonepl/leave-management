using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Contracts
{
   public interface IRepositoryBase<T> where T: class
    {

        // Return all records from class type (table) requested
        ICollection<T> FindAll();
        // Find specific record
        T FindById(int id);
        //Operations on varible entity of class type T
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        bool Save();
    }
    //public interface ILeaveHistoryRepository : IRepositoryBase<LeaveHistory>
    //{
    //}

    //public interface ILeaveAllocationRepository : IRepositoryBase<LeaveAllocation>
    //{
    //}

    //public interface ILeaveTypeRepository : IRepositoryBase<LeaveType>
    //{
    //    ICollection<LeaveType> GetEmployeesByLeaveType(int id);

    //}
}
