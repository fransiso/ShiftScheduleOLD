namespace ShiftSchedule.Domain.Entities.Base
{
    /// <summary>
    /// Base class for all Entity types.
    /// </summary>

    public class Entity<TPrimaryKey> : IEntity<TPrimaryKey>
    {
        /// <summary>
        /// Unique identifier for this entity.
        /// </summary>
        public virtual TPrimaryKey Id { get; set; }
    }
}