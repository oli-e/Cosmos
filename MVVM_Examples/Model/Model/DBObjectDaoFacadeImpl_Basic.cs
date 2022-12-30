using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM_Examples.Model.DAO;

namespace MVVM_Examples.Model.Model
{
    public interface IDBObjectDaoFacade_Basic
    {
        Task<List<DBObject_Basic>> GetDBObjects_BasicAsync();
        Task<DBObject_Basic> GetDBObject_BasicAsync(int id);
        Task<DBObject_Basic> AddDBObject_BasicAsync(DBObject_Basic obj);
        Task<DBObject_Basic> UpdateDBObject_BasicAsync(DBObject_Basic obj);
        Task DeleteDBObject_BasicAsync(int id);
    }

    public class DBObjectDaoFacadeImpl_Basic : IDBObjectDaoFacade_Basic
    {
        List<DBObject_Basic> _dbObjects = new List<DBObject_Basic>()
        {
            new DBObject_Basic()
            {
                ID = 1,
                Name = "Star",
                Weight = 150
            },
            new DBObject_Basic()
            {
                ID = 2,
                Name = "Planet",
                Weight = 50
            },
            new DBObject_Basic()
            {
                ID = 3,
                Name = "Galaxy",
                Weight = 1000
            }
        };

        public Task<DBObject_Basic> AddDBObject_BasicAsync(DBObject_Basic obj)
        {
            _dbObjects.Add(obj);
            return Task.FromResult(obj);
        }

        public Task DeleteDBObject_BasicAsync(int id)
        {
            var obj = _dbObjects.First(i => i.ID == id);
            _dbObjects.Remove(obj);
            return Task.CompletedTask;
        }

        public Task<DBObject_Basic> GetDBObject_BasicAsync(int id)
        {
            var obj = _dbObjects.First(i => i.ID == id);

            var nobj = new DBObject_Basic();

            nobj.Name = obj.Name;
            nobj.Weight = obj.Weight;
            nobj.ID = obj.ID;

            return Task.FromResult(nobj);
        }

        public Task<List<DBObject_Basic>> GetDBObjects_BasicAsync()
        {
            List<DBObject_Basic> nList = new List<DBObject_Basic>(_dbObjects);
            return Task.FromResult(nList);
        }

        public Task<DBObject_Basic> UpdateDBObject_BasicAsync(DBObject_Basic obj)
        {
            var tobj = _dbObjects.First(i => i.ID == obj.ID);

            tobj.Name = obj.Name;
            tobj.Weight = obj.Weight;
            tobj.ID = obj.ID;

            return Task.FromResult(tobj);
        }
    }
}
