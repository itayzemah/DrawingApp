using EntityAndBoundary.Boundary;
using EntityAndBoundary.Entity;
using Microsoft.EntityFrameworkCore;
using Oracle.ManagedDataAccess.Client;
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
            StringBuilder sb = new StringBuilder();
            sb.Append("insert INTO users (userid, userEmail,userName)VALUES('");
            sb.Append(newUser.UserID);
            sb.Append("','");
            sb.Append(newUser.userEmail);
            sb.Append("','");
            sb.Append(newUser.UserName);
            sb.Append("')");
            //var dbRV= dal.ExecuteQuery(dal.Connect(dal.ConnectionString), sb.ToString());
            //DbParameter id = new OracleParameter() { ParameterName = "userid", Value = newUser.UserID };
            //DbParameter userName = new OracleParameter() { ParameterName = "userName", Value = newUser.UserName };
            //DbParameter userEmail = new OracleParameter() { ParameterName = "userEmail", Value = newUser.userEmail };

            DbParameter[] dbParameters = {
                new OracleParameter() { ParameterName = "userid", Value = newUser.UserID }
                , new OracleParameter() { ParameterName = "userName",Value = newUser.UserName }
                , new OracleParameter() { ParameterName = "userEmail", Value = newUser.userEmail } };
            dal.ExecuteSPQuery(dal.Connect(dal.ConnectionString), "ADD_USER", dbParameters);
            return newUser;
        }

        public UserEntity Login(string userEmail)
        {
            throw new NotImplementedException();
        }

        public UserEntity RemoveUser(UserEntity userToRemove)
        {
            throw new NotImplementedException();
        }
    }
}
