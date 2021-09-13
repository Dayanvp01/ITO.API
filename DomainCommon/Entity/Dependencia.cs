using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITO.API.DomainCommon.Entity
{
    public class Dependencia
    {
        public Guid? Id { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        /// <summary>
        /// Propiedad para manejar el borrado lógico
        /// </summary>
        public bool Activo { get; set; }

        public virtual IEnumerable<Empleado> Empleados { get; set; }
    }
}
