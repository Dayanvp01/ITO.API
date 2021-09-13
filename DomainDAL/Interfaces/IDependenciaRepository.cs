using ITO.API.DomainCommon.Entity;
using System;
using System.Collections.Generic;


namespace ITO.API.DomainDAL.Interfaces
{
    public interface IDependenciaRepository
    {
        public Guid Create(Dependencia entity);
        public Dependencia Get(Guid id);
        public IEnumerable<Dependencia> Get();
        public void Update(Dependencia entity);
        public void Delete(Dependencia entity);

    }
}
