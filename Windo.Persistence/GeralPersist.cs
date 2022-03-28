using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windo.Persistence.Contratos;

namespace Windo.Persistence
{
    public class GeralPersist : IGeralPersist
    {
        protected readonly windo_baseContext _contexto;
        public GeralPersist(windo_baseContext contexto)
        {
            this._contexto = contexto;

        }
        public void Add<T>(T entity) where T : class
        {
            _contexto.Add(entity);           
        }       

        public void Update<T>(T entity) where T : class
        {
            _contexto.Update(entity);
        }
        public void Delete<T>(T entity) where T : class
        {
            _contexto.Remove(entity);
        }

        public void DeleteRange<T>(T[] arrayEntity) where T : class
        {
            _contexto.RemoveRange(arrayEntity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _contexto.SaveChangesAsync()) > 0;
        }
    }
}
