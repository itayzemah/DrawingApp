using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAL.DALContracts
{
    public interface IInfraDAL
    {
        public IMyDBConnection Connect(string stringConnection);

        public IMyDBParamenter CreateParameter(string paramName, object val);

        public IMyDBParamenter getOutParam();
        DataSet ExecuteSPQuery(IMyDBConnection connection, string spName,
            params IMyDBParamenter[] parameters);

        DataSet ExecuteQuery(IMyDBConnection connection, string query);
    }
}
