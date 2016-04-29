using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekhub.Framework
{
    public interface IRepository<TId, TEntity> where TEntity : class
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dto"></param>
        /// <returns>ID of the new object</returns>
        TId Add(TEntity dto);
        IReadOnlyList<TId> AddRange(IEnumerable<TEntity> dtos);
        bool Exists(TId id);
        TEntity Get(TId id);
        IReadOnlyList<TEntity> GetRange(IEnumerable<TId> ids);
        void Update(TEntity dto);
        void Delete(TEntity dto);
    }
}
