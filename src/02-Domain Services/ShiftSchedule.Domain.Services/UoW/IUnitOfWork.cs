using System;
using ShiftSchedule.Domain.Interfaces.Base;

namespace ShiftSchedule.Domain.Services.UoW
{
    /// <summary>
    /// Defines a unit of work.
    /// </summary>
     /// <summary>
    /// Represents a transactional job.
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// Opens database connection and begins transaction.
        /// </summary>
        void BeginTransaction();

        /// <summary>
        /// Commits transaction and closes database connection.
        /// </summary>
        void Commit();

        /// <summary>
        /// Rollbacks transaction and closes database connection.
        /// </summary>
        void Rollback();
    }
    
}