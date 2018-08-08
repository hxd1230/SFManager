using System;
using Xiao.D.Core;
using Xiao.D.Core.Data;

namespace Xiao.D.Data
{
    public class EFRepository<T> : IRepository<T> where T : BaseEntity
    {
        public T GetById(object id)
        {
            XiaoDbContext db = new XiaoDbContext();
            return db.Set<T>().Find(id);
        }

        public void Insert(T entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException("entity");
                XiaoDbContext db = new XiaoDbContext();
                db.Set<T>().Add(entity);
                db.SaveChanges();
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
