using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAL.DALContracts
{
    public interface IInfraDAL
    {
        public MyDBConnection Connect(string stringConnection);

        DataSet ExecuteSPQuery(MyDBConnection connection, string spName,
            params MyDBParamenter[] parameters);

        DataSet ExecuteQuery(MyDBConnection connection, string query);
    }
}
