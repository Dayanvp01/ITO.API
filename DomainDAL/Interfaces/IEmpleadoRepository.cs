using ITO.API.DomainCommon.Entity;
using System;
using System.Collections.Generic;

namespace ITO.API.DomainDAL.Interfaces
{
    public interface IEmpleadoRepository
    {
        public Guid Create(Empleado entity);
        public Empleado Get(Guid id);
        public IEnumerable<Empleado> Get();
        public void Update(Empleado entity);
        public void Delete(Empleado entity);
    }
}
