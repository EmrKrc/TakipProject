using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EntityProject
{
    public class RepositoryBase<Entity,Context>
        where Entity : class,new()
        where Context : DbContext, new()
    {
        Context db = new Context();
        public void AddorUpdate(Entity entity)
        {
            db.Set<Entity>().AddOrUpdate(entity);
            //db.SaveChanges();
        }
        public void Delete(Expression<Func<Entity, bool>> obj)
        {
            var model = db.Set<Entity>().FirstOrDefault(obj);
            db.Set<Entity>().Remove(model);
        }
        public List<Entity> GetList(Expression<Func<Entity, bool>> obj=null)//null
        {
            List<Entity> liste;
            if (obj == null)
               liste = db.Set<Entity>().ToList();
            else
                liste = db.Set<Entity>().Where(obj).ToList();
                return liste;
        }
        public Entity GetByFilter(Expression<Func<Entity, bool>> obj)
        {
            return db.Set<Entity>().FirstOrDefault(obj);
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
