using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITO.API.DomainCommon.DTO
{
    public class EmpleadoDto
    {
        public Guid? Id { get; set; }

        public Guid DependenciaId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }

    }
}
