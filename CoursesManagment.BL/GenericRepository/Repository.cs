using CourseManagment.DAL.Entities;
using CoursesManagment.BL.IGenericRepository;
using CoursesManagment.DAL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoursesManagment.BL.GenericRepository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationContext _context;

        public Repository(ApplicationContext Context)
        {
            _context = Context;
        }
        public async Task<bool> Add(T obj)
        {
            try
            {
                var result = await _context.Set<T>().AddAsync(obj);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                throw new Exception("There Is Problem During Addition Operation");
            }
        }

        public async Task<bool> Delete(int Id)
        {
            try
            {
                var currentObject = _context.Set<T>().Find(Id);
                if (currentObject != null)
                {
                    _context.Set<T>().Remove(currentObject);
                    await _context.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        public async Task<IEnumerable<T>> Filter(Expression<Func<T, bool>> filter)
        {

            try
            {
                var result =await _context.Set<T>().Where(filter).ToListAsync();
                return result;
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }

        }

        public async Task<IEnumerable<T>> GetAll(string[] includes=null)
        {

            IQueryable<T> query= _context.Set<T>();
            try
            {
                if(includes!=null)
                    foreach (var item in includes)
                    {
                        
                        query.Include(item);
                    }

               await query.ToListAsync();
                return query;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public async Task<T> GetById(int id)
        {
            try
            {
                return await _context.Set<T>().FindAsync(id);

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<T> Update(T Obj)
        {
            try
            {
                var result=_context.Set<T>().Update(Obj);
                await _context.SaveChangesAsync();
                return Obj;
            }
            catch(Exception ex) { throw ex.InnerException; };
        }

    }
}
