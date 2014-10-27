using System;
using ShiftSchedule.Domain.Entities.Base;

namespace ShiftSchedule.Domain.Services.Auditing
{
    /// <summary>
    /// This interface is implemented by entities which wanted to store deletion informations (who and when deleted).
    /// </summary>
    public interface IDeletionAudited 
    {
        /// <summary>
        /// Which user deleted this entity?
        /// </summary>
        long? DeleterUserId { get; set; }

        /// <summary>
        /// Deletion time of this entity.
        /// </summary>
        DateTime? DeletionTime { get; set; }
    }
}