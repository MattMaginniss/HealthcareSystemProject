using System.Collections.Generic;

namespace HealthcareProjectBeamMaginniss.DAL.Interfaces
{
    /// <summary>
    ///     Repository interface for tables
    /// </summary>
    /// <typeparam name="T">The datatype</typeparam>
    public interface IRepository<T>
    {
        /// <summary>
        ///     Adds the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void Add(T entity);

        /// <summary>
        ///     Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>The identified entity</returns>
        T GetById(int id);

        /// <summary>
        ///     Gets all.
        /// </summary>
        /// <returns>All entities</returns>
        IList<T> GetAll();
    }
}