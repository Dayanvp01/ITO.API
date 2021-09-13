using AutoMapper;
using ITO.API.DomainBL.Interfaces;
using ITO.API.DomainCommon.DTO;
using ITO.API.DomainCommon.Entity;
using ITO.API.DomainDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ITO.API.DomainBL
{
    public class EmpleadoBL : IEmpleadoBL
    {
        private readonly IEmpleadoRepository _empleadoRepository;
        // Mapper
        private readonly IMapper _mapper;
        public EmpleadoBL(IEmpleadoRepository empleadoRepository, IMapper mapper)
        {
            _empleadoRepository = empleadoRepository;
            _mapper = mapper;
        }

        public Guid CrearEmpleado(EmpleadoDto entityDto)
        {
            try
            {
                Empleado entity = new Empleado();
                entity = _mapper.Map<Empleado>(entityDto);
                entity.Id = null;
                return _empleadoRepository.Create(entity);
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
                return _mapper.Map<List<Empleado>, List<EmpleadoDto>>(_empleadoRepository.Get().ToList());
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
                bool result = false;
                Empleado entity = _empleadoRepository.Get((Guid)empleadoDto.Id);
                if (entity != null)
                {
                    entity.Nombres = empleadoDto.Nombres;
                    entity.Apellidos = empleadoDto.Apellidos;
                    _empleadoRepository.Update(entity);
                    result = true;
                }
                return result;
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
                bool result = false;
                Empleado entity = _empleadoRepository.Get(id);
                if (entity != null)
                {
                    _empleadoRepository.Delete(entity);
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
