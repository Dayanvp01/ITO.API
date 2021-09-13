using ITO.API.DomainBL.Interfaces;
using ITO.API.DomainCommon.DTO;
using ITO.API.DomainServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITO.API.DomainServices
{
    public class EmpleadoService : IEmpleadoService
    {
        private readonly IEmpleadoBL _empleadoBL;

        public EmpleadoService(IEmpleadoBL empleadoBL)
        {
            _empleadoBL = empleadoBL;
        }



        public Guid CrearEmpleado(EmpleadoDto entityDto)
        {
            try
            {
                return _empleadoBL.CrearEmpleado(entityDto);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<EmpleadoDto> GetEmpleados()
        {
            try
            {
                return _empleadoBL.GetEmpleados();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool ActualizarEmpleado(EmpleadoDto empleadoDto)
        {
            try
            {
                return _empleadoBL.ActualizarEmpleado(empleadoDto);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool BorrarEmpleado(Guid id)
        {
            try
            {
                return _empleadoBL.BorrarEmpleado(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
