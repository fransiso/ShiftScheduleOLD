using NHibernate;
using NHibernate.Linq;
using ShiftSchedule.Domain.Interfaces;
using ShiftSchedule.Infrastructure.Data.NHibernate.UoW;

namespace ShiftSchedule.Infrastructure.Data.ORM.NHibernate.NHRepositories.Base
{
    /// <summary>
    /// Base class for all repositories those uses NHibernate.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    /// <typeparam name="TPrimaryKey">Primary key type of the entity</typeparam>
    public abstract class NhRepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        /// <summary>
        /// Gets the NHibernate session object to perform database operations.
        /// </summary>
        protected ISession Session { get { return NhUnitOfWork.Current.Session; } }

        public void Update(TEntity entity)
        {
            Session.Update(entity);
        }

        public void Add(TEntity obj)
        {
            Session.Save(obj);
        }

        public TEntity GetById(int id)
        {
            return Session.Get<TEntity>(id);
        }

        System.Collections.Generic.IEnumerable<TEntity> IRepositoryBase<TEntity>.GetAll()
        {
            return Session.Query<TEntity>();
        }

        public void Remove(TEntity obj)
        {
            Session.Delete(Session.Load<TEntity>(obj));
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}