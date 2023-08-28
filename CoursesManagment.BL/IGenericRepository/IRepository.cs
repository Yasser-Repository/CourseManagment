using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoursesManagment.BL.IGenericRepository
{
    public interface IRepository<T> where T : class
    {
        public Task<IEnumerable<T>> GetAll(string[] includes=null);
        public Task<T> GetById(int id);
        public Task<IEnumerable<T>> Filter(Expression<Func<T,bool>> filter);
        public Task<T> Update(T Obj);
        public Task<bool> Delete(int Id);
        public Task<bool> Add(T obj);
 
    }
}
