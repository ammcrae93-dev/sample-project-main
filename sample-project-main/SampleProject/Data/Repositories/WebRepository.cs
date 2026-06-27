using BusinessEntities;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    [AutoRegister]
    public class WebRepository<T> : IRepository<T> where T:IdObject
    {
        private IEnumerable<T> _collection;

        public void Save(T entity) 
        {
            List<T> items = _collection.ToList();
            items.Add(entity);
            _collection = items;
        }

        public void Delete(T entity)
        {
            if(_collection.Any())
            {
                List<T> items = _collection.ToList();
                items.Remove(entity);
                _collection = items;
            }
        }

        public T Get(Guid id)
        {
            return _collection.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return _collection;
        }
    }
}
