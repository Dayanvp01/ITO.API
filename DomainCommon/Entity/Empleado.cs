using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITO.API.DomainCommon.Entity
{
    public class Empleado
    {
        public Guid? Id { get; set; }

        /// <summary>
        /// Id dependencia que pertenece
        /// </summary>
        public Guid DependenciaId { get; set; }
        /// <summary>
        /// Entidad Dependencia
        /// </summary>
        public virtual Dependencia Dependencia { get; set; }

        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        /// <summary>
        /// Propiedad para manejar el borrado lógico
        /// </summary>
        public bool Activo { get; set; }
    }
}
