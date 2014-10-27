using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Linq;
using ShiftSchedule.Domain.Entities.Base;
using ShiftSchedule.Domain.Interfaces.Base;
using ShiftSchedule.Infrastructure.Data.NHibernate.UoW;

namespace ShiftSchedule.Infrastructure.Data.NHibernate.Repositories.Base

{
    /// <summary>
    /// Base class for all repositories those uses NHibernate.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    /// <typeparam name="TPrimaryKey">Primary key type of the entity</typeparam>
    public abstract class NhRepositoryBase<TEntity, TPrimaryKey> : IRepository<TEntity, TPrimaryKey> where TEntity : Entity<TPrimaryKey>
    {
        /// <summary>
        /// Gets the NHibernate session object to perform database operations.
        /// </summary>
        protected ISession Session { get { return NhUnitOfWork.Current.Session; } }

        /// <summary>
        /// Used to get a IQueryable that is used to retrive object from entire table.
        /// </summary>
        /// <returns>IQueryable to be used to select entities from database</returns>
        public IQueryable<TEntity> GetAll()
        {
            return Session.Query<TEntity>();
        }

        /// <summary>
        /// Gets an entity.
        /// </summary>
        /// <param name="key">Primary key of the entity to get</param>
        /// <returns>Entity</returns>
        public TEntity Get(TPrimaryKey key)
        {
            return Session.Get<TEntity>(key);
        }

        /// <summary>
        /// Inserts a new entity.
        /// </summary>
        /// <param name="entity">Entity</param>
        public void Insert(TEntity entity)
        {
            Session.Save(entity);
        }

        /// <summary>
        /// Updates an existing entity.
        /// </summary>
        /// <param name="entity">Entity</param>
        public void Update(TEntity entity)
        {
            Session.Update(entity);
        }

        /// <summary>
        /// Deletes an entity.
        /// </summary>
        /// <param name="id">Id of the entity</param>
        public void Delete(TPrimaryKey id)
        {
            Session.Delete(Session.Load<TEntity>(id));
        }
    }
}