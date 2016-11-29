using System.Collections.Generic;

namespace HealthcareProjectBeamMaginniss.DAL.Interfaces
{
    public interface IRepository<T>
    {
        #region Methods

        void Add(T entity);

        T GetById(int id);

        IList<T> GetAll();

        #endregion
    }
}