﻿using ITO.API.DomainCommon.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITO.API.DomainBL.Interfaces
{
    public interface IEmpleadoBL
    {
        public List<EmpleadoDto> GetEmpleados();
        public Guid CrearEmpleado(EmpleadoDto entityDto);
        public bool ActualizarEmpleado(EmpleadoDto empleadoDto);
        public bool BorrarEmpleado(Guid id);
    }
}
