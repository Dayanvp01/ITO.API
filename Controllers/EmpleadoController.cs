using ITO.API.DomainCommon.DTO;
using ITO.API.DomainServices.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITO.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        private readonly IEmpleadoService _empleadoService;

        public EmpleadoController(IEmpleadoService empleadoService)
        {
            _empleadoService = empleadoService;
        }

        /// <summary>
        /// Crea Dependencia
        /// </summary>
        /// <param name="dependencia">objeto dependencia</param>
        /// <returns>Id de la dependencia</returns>
        [HttpPut]
        [Consumes("application/json")]
        [Route("CrearEmpleado")]
        public ActionResult CrearEmpleado(EmpleadoDto empleado)
        {
            try
            {
                return Ok(_empleadoService.CrearEmpleado(empleado));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

        /// <summary>
        /// Consulta las dependencias existentes
        /// </summary>
        /// <returns>dependencias activas</returns>
        [HttpGet]
        [Consumes("application/json")]
        [Route("GetEmpleados")]
        public ActionResult GetEmpleados()
        {
            try
            {
                var empleados = _empleadoService.GetEmpleados();
                if (empleados.Count > 0)
                {
                    return Ok(empleados);
                }

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Actualiza Dependencia
        /// </summary>
        /// <param name="dependencia">objeto dependencia</param>
        /// <returns>Id de la dependencia</returns>
        [HttpPut]
        [Consumes("application/json")]
        [Route("ActualizarEmpleado")]
        public ActionResult ActualizarEmpleado(EmpleadoDto empleado)
        {
            try
            {
                return Ok(_empleadoService.ActualizarEmpleado(empleado));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Elimina Dependencia
        /// </summary>
        /// <param name="dependencia">objeto dependencia</param>
        /// <returns>Id de la dependencia</returns>
        [HttpDelete("{empleadoId}")]
        [Consumes("application/json")]
        [Route("BorrarEmpleado")]
        public ActionResult BorrarEmpleado(Guid empleadoId)
        {
            try
            {
                return Ok(_empleadoService.BorrarEmpleado(empleadoId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}
