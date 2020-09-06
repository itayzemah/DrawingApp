using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using DAL.DALContracts;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;

namespace DAL.DALImlementations
{
    public class OracleConnectionAdapter: MyDBConnection
    {
        public OracleConnection Connection { get; set; }
        public string ConnectionString { get; set; }

        public OracleConnectionAdapter(string connectionString)
        {
            ConnectionString = connectionString;

        }
    }
    public class OracleDataAccessLayer : IDataAccessLayer
    {
        public string ConnectionString { get; set; }
        private static IDbConnection Connection = null;
        public OracleDataAccessLayer(string connectionString)
        {
            this.ConnectionString = connectionString;
        }


        public IDbConnection Connect(string strConnection)
        {
            if(Connection == null)
            {
                return new OracleConnection(ConnectionString);
            }
            else
            {
                return Connection;
            }
        }

        public DataSet ExecuteQuery(IDbConnection connection, string query)
        {
            var command = new OracleCommand();
            command.CommandText = query;
            command.CommandType = CommandType.Text;
            command.Connection = connection as OracleConnection;

            DataSet retval = new DataSet();
            OracleDataAdapter dataAdapter = new OracleDataAdapter(command);
            dataAdapter.Fill(retval);
            return retval;
        }

        public DataSet ExecuteSPQuery(IDbConnection connection, string spName, params DbParameter[] parameters)
        {
            var command = new OracleCommand();
            command.CommandText = spName;
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = (connection as OracleConnection);


            foreach (var parameter in parameters)
                command.Parameters.Add(parameter);

            DataSet retval = new DataSet();
            OracleDataAdapter dataAdapter = new OracleDataAdapter(command);
            dataAdapter.Fill(retval);
           

            return retval;
        }
    }
}
