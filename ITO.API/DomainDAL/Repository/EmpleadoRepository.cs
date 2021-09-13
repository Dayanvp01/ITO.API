using ITO.API.DomainCommon.Entity;
using ITO.API.DomainDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITO.API.DomainDAL.Repository
{
    public class EmpleadoRepository : IEmpleadoRepository
    {
        /// <summary>
        /// Contexto del ORM
        /// </summary>
        private readonly DomainContext _context;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        public EmpleadoRepository(DomainContext context)
        {
            _context = context;
        }

        #region Create
        public Guid Create(Empleado entity)
        {
            try
            {
                _context.Empleados.Add(entity);
                _context.SaveChanges();
                return (Guid)entity.Id;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Read

        public Empleado Get(Guid id)
        {
            try
            {
                return _context.Empleados.Where(x => x.Id == id && x.Activo == true).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<Empleado> Get()
        {
            try
            {
                return _context.Empleados.Where(x => x.Activo == true);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Update
        public void Update(Empleado entity)
        {
            try
            {
                _context.Empleados.Update(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion

        #region Delete
        public void Delete(Empleado entity)
        {
            try
            {
                entity.Activo = false;
                Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion

    }
}
