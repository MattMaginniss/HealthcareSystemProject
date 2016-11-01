using System.Collections.Generic;

namespace HealthcareProjectBeamMaginniss.DAL.Interfaces
{
    public interface IRepository<T>
    {
        void Add(T entity);

        T GetById(int id);

        IList<T> GetAll();
    }
}