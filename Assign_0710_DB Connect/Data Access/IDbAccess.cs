using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_0710_DB_Connect.Data_Access
{
    public interface IDbAccess<TEntity,in tpk> where TEntity : class
    {
        public IEnumerable<TEntity> GetAllRecords();

        public TEntity Create(TEntity entity);

        public TEntity Update(TEntity entity);

        public bool Delete(TEntity entity);
    }
}
