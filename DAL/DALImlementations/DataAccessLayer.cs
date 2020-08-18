using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;


namespace DAL.DALImlementations
{

    public class DataAccessLayer : IDataAccessLayer
    {
        public IDbConnection Connect(string strConnection)
        {
            throw new NotImplementedException();
        }

        public DataSet ExecuteQuery(IDbConnection connection, string query)
        {
            throw new NotImplementedException();
        }

        public DataSet ExecuteSPQuery(IDbConnection connection, string spName, params DbParameter[] parameters)
        {
            throw new NotImplementedException();
        }
    }
}
