using ITO.API.DomainBL.Interfaces;
using ITO.API.DomainCommon.DTO;
using ITO.API.DomainServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITO.API.DomainServices
{
    public class DependenciaService : IDependenciaService
    {
        private readonly IDependenciaBL _dependenciaBL;

        public DependenciaService(IDependenciaBL dependenciaBL)
        {
            _dependenciaBL = dependenciaBL;
        }

        /// <summary>
        /// Servicio que obtiene todas las dependencias activas
        /// </summary>
        /// <returns></returns>
        public List<DependenciaDto> GetDependencias()
        {
            try
            {
                return _dependenciaBL.GetDependencias();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Guid CrearDependencia(DependenciaDto entityDto)
        {
            try
            {
                return _dependenciaBL.CrearDependencia(entityDto);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool ActualizarDependencia(DependenciaDto dependenciaDto)
        {
            try
            {
                return _dependenciaBL.ActualizarDependencia(dependenciaDto);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool BorrarDependencia(Guid id)
        {
            try
            {
                return _dependenciaBL.BorrarDependencia(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
