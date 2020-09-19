using EntityAndBoundary.Boundary;
using EntityAndBoundary.Entity;
using Microsoft.EntityFrameworkCore;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace DAL.DALImlementations
{
    public class UserDAL : IUserDAL
    {
        private IDataAccessLayer dal;

        public UserDAL(IDataAccessLayer dal)
        {
            this.dal = dal;
        }

        public UserEntity Create(UserEntity newUser)
        {
            DbParameter[] dbParameters = {
                new OracleParameter() { ParameterName = "userid", Value = newUser.UserID }
                , new OracleParameter() { ParameterName = "userEmail", Value = newUser.userEmail }
                , new OracleParameter() { ParameterName = "userName",Value = newUser.UserName }
                , new OracleParameter() { ParameterName = "seccess",OracleDbType = OracleDbType.RefCursor, Direction=System.Data.ParameterDirection.Output}
                 };
            var ds = dal.ExecuteSPQuery(dal.Connect(dal.ConnectionString), "ADD_USER", dbParameters);
            if (ds.Tables[0].Rows[0]["seccess"] as string == "T")
            {
                return newUser;
            }
            return null;

            //TODO change return value

        }

        public UserEntity Login(string userEmail)
        {
            DbParameter[] dbParameters = {
                new OracleParameter() { ParameterName = "userEmail", Value = userEmail },
                new OracleParameter() { ParameterName = "USER_RV", OracleDbType = OracleDbType.RefCursor, Direction=System.Data.ParameterDirection.Output } };
            var rv = dal.ExecuteSPQuery(dal.Connect(dal.ConnectionString), "LOGIN", dbParameters);
            if (rv.Tables[0].Rows.Count != 1)
            {
                return null;
            }
            var userDataSet = rv.Tables[0].Rows[0];
            var id1 = userDataSet["USERID"];
            var name1 = userDataSet["USERNAME"];
            var email1 = userDataSet["USEREMAIL"];
            return new UserEntity(id1 as string, email1 as string, name1 as string);
        }

        public UserEntity RemoveUser(UserEntity userToRemove)
        {
            throw new NotImplementedException();
        }
    }
}
