using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDataAccessLayer
    {
        public string ConnectionString { get; set; }

        public IDbConnection Connect(string strConnection);

        DataSet ExecuteSPQuery(IDbConnection connection, string spName,
            params DbParameter[] parameters);

        DataSet ExecuteQuery(IDbConnection connection, string query);

    }
}
