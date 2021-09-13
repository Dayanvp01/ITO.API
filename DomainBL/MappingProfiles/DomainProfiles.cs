using AutoMapper;
using ITO.API.DomainCommon.DTO;
using ITO.API.DomainCommon.Entity;

namespace ITO.API.DomainBL.MappingProfiles
{
    public class DomainProfiles:Profile
    {
        public DomainProfiles()
        {
            CreateMap<Dependencia, DependenciaDto>().ReverseMap();
            CreateMap<Empleado, EmpleadoDto>().ReverseMap();
        }

    }
}
