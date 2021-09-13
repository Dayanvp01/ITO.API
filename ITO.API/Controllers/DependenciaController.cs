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
    public class DependenciaController : ControllerBase
    {
        private readonly IDependenciaService _dependenciaService;

        public DependenciaController(IDependenciaService dependenciaService)
        {
            _dependenciaService = dependenciaService;
        }

        /// <summary>
        /// Crea Dependencia
        /// </summary>
        /// <param name="dependencia">objeto dependencia</param>
        /// <returns>Id de la dependencia</returns>
        [HttpPut]
        [Consumes("application/json")]
        [Route("CrearDependencia")]
        public ActionResult CrearDependencia(DependenciaDto dependencia)
        {
            try
            {
                return Ok(_dependenciaService.CrearDependencia(dependencia));
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
        [Route("GetDependencias")]
        public ActionResult GetDependencias()
        {
            try
            {
                var dependencias = _dependenciaService.GetDependencias();
                if (dependencias.Count > 0)
                {
                    return Ok(dependencias);
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
        [Route("ActualizarDependencia")]
        public ActionResult ActualizarDependencia(DependenciaDto dependencia)
        {
            try
            {
                return Ok(_dependenciaService.ActualizarDependencia(dependencia));
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
        [HttpDelete("{dependenciaId}")]
        [Consumes("application/json")]
        [Route("BorrarDependencia")]
        public ActionResult BorrarDependencia(Guid dependenciaId)
        {
            try
            {
                return Ok(_dependenciaService.BorrarDependencia(dependenciaId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}
