using AutoMapper;
using ITO.API.DomainBL.Interfaces;
using ITO.API.DomainCommon.DTO;
using ITO.API.DomainCommon.Entity;
using ITO.API.DomainDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITO.API.DomainBL
{
    public class DependenciaBL : IDependenciaBL
    {
        private readonly IDependenciaRepository _dependenciaRepository;
        // Mapper
        private readonly IMapper _mapper;
        public DependenciaBL(IDependenciaRepository dependenciaRepository, IMapper mapper)
        {
            _dependenciaRepository = dependenciaRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Obtiene todas las dependencias activas
        /// </summary>
        /// <returns></returns>
        public List<DependenciaDto> GetDependencias()
        {
            try
            {
                var dependencias = _dependenciaRepository.Get().ToList();
               return _mapper.Map<List<Dependencia>, List<DependenciaDto>>(_dependenciaRepository.Get().ToList());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Crea dependencia
        /// </summary>
        /// <param name="entityDto">dependencia a crear</param>
        /// <returns></returns>
        public Guid CrearDependencia(DependenciaDto entityDto)
        {
            try
            {
                Dependencia entity = new Dependencia();
                entity = _mapper.Map<Dependencia>(entityDto);
                entity.Id = null;
                return _dependenciaRepository.Create(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Actualiza la información de la dependencia
        /// </summary>
        /// <param name="dependenciaDto"></param>
        /// <returns></returns>
        public bool ActualizarDependencia(DependenciaDto dependenciaDto)
        {
            try
            {
                bool result = false;
                Dependencia entity = _dependenciaRepository.Get(dependenciaDto.Id);
                if (entity != null)
                {
                    entity.Nombre = dependenciaDto.Nombre;
                    entity.Codigo = dependenciaDto.Codigo;
                    _dependenciaRepository.Update(entity);
                    result = true;
                }
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Realiza el borrado lógico de la dependencia
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool BorrarDependencia(Guid id)
        {
            try
            {
                bool result = false;
                Dependencia entity = _dependenciaRepository.Get(id);
                if (entity != null)
                {
                    _dependenciaRepository.Delete(entity);
                    result = true;
                }
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



    }
}
