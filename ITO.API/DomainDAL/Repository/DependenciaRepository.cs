using ITO.API.DomainCommon.Entity;
using ITO.API.DomainDAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ITO.API.DomainDAL.Repository
{
    public class DependenciaRepository : IDependenciaRepository
    {

        /// <summary>
        /// Contexto del ORM
        /// </summary>
        private readonly DomainContext _context;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        public DependenciaRepository(DomainContext context)
        {
            _context = context;
        }

        #region Create
        public Guid Create(Dependencia entity)
        {
            try
            {
                _context.Dependencia.Add(entity);
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

        public Dependencia Get(Guid id)
        {
            try
            {
                return _context.Dependencia
                    .Include(x=> x.Empleados)
                    .Where(x => x.Id == id && x.Activo == true).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<Dependencia> Get()
        {
            try
            {
                return _context.Dependencia.Where(x => x.Activo == true);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Update
        public void Update(Dependencia entity)
        {
            try
            {
                _context.Dependencia.Update(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion

        #region Delete
        public void Delete(Dependencia entity)
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
