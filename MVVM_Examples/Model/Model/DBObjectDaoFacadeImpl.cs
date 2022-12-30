using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM_Examples.Model.DAO;

namespace MVVM_Examples.Model.Model
{
    public interface IDBObjectDaoFacade
    {
        Task<List<DBObject>> GetDBObjectsAsync();
        Task<DBObject> GetDBObjectAsync(int id);
        Task<DBObject> AddDBObjectAsync(DBObject obj);
        Task<DBObject> UpdateDBObjectAsync(DBObject obj);
        Task DeleteDBObjectAsync(int id);
    }

    public class DBObjectDaoFacadeImpl : IDBObjectDaoFacade
    {
        List<DBObject> _dbObjects = new List<DBObject>()
        {
            new DBObject()
            {
                ID = 1,
                Name = "Star",
                Weight = 150
            },
            new DBObject()
            {
                ID = 2,
                Name = "Planet",
                Weight = 50
            },
            new DBObject()
            {
                ID = 3,
                Name = "Galaxy",
                Weight = 1000
            }
        };

        public Task<DBObject> AddDBObjectAsync(DBObject obj)
        {
            _dbObjects.Add(obj);
            return Task.FromResult(obj);
        }

        public Task DeleteDBObjectAsync(int id)
        {
            var obj = _dbObjects.First(i => i.ID == id);
            _dbObjects.Remove(obj);
            return Task.CompletedTask;
        }

        public Task<DBObject> GetDBObjectAsync(int id)
        {
            var obj = _dbObjects.First(i => i.ID == id);

            var nobj = new DBObject();

            nobj.Name = obj.Name;
            nobj.Weight = obj.Weight;
            nobj.ID = obj.ID;

            return Task.FromResult(nobj);
        }

        public Task<List<DBObject>> GetDBObjectsAsync()
        {
            List<DBObject> nList = new List<DBObject>(_dbObjects);
            return Task.FromResult(nList);
        }

        public Task<DBObject> UpdateDBObjectAsync(DBObject obj)
        {
            var tobj = _dbObjects.First(i => i.ID == obj.ID);

            tobj.Name = obj.Name;
            tobj.Weight = obj.Weight;
            tobj.ID = obj.ID;

            return Task.FromResult(tobj);
        }
    }
}
