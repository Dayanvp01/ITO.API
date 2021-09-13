using ITO.API.DomainCommon.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITO.API.DomainBL.Interfaces
{
    public interface IDependenciaBL
    {
        public List<DependenciaDto> GetDependencias();
        public Guid CrearDependencia(DependenciaDto entityDto);
        public bool ActualizarDependencia(DependenciaDto dependenciaDto);
        public bool BorrarDependencia(Guid id);
    }
}
