using EntityAndBoundary.Boundary;
using EntityAndBoundary.Entitiy;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace DAL.DALImlementations
{
    public class SharingDAL : ISharingDAL
    {
        private IDataAccessLayer dal;

        public SharingDAL(IDataAccessLayer dal)
        {
            this.dal = dal;
        }

        public ShareEntity Create(ShareEntity share)
        {
            ShareEntity retval = null;
            DbParameter[] dbParameters = {
                new OracleParameter() { ParameterName = "P_NEW_USER_SHARE", Value = share.UserInShare}
                ,new OracleParameter() { ParameterName = "P_DOC_ID", Value = share.DocID}
                , new OracleParameter() {
                    ParameterName = "SHARE_RETVAL", OracleDbType = OracleDbType.RefCursor, Direction=System.Data.ParameterDirection.Output }
            };
            var qResult = dal.ExecuteSPQuery(dal.Connect(dal.ConnectionString), "CREATE_SHARE", dbParameters);
            if (qResult.Tables[0].Rows.Count != 0)
            {
                var newShare = qResult.Tables[0].Rows[0];
                retval = new ShareEntity() { DocID = newShare["docid"] as string, UserInShare = newShare["userid"] as string };
            }
            return retval;
        }

        public List<ShareEntity> GetShareByUser(string userID)
        {
            List<ShareEntity> retval = new List<ShareEntity>();
            DbParameter[] dbParameters = {
                new OracleParameter() { ParameterName = "P_USER_ID", Value = userID}
                , new OracleParameter() {
                    ParameterName = "RV_SHARED_USERS", OracleDbType = OracleDbType.RefCursor, Direction=System.Data.ParameterDirection.Output }
            };
            var qResult = dal.ExecuteSPQuery(dal.Connect(dal.ConnectionString), "GET_DOC_SHARED", dbParameters);
            var allShares = qResult.Tables[0].Rows;
            for (int row = 0; row < allShares.Count; row++)
            {
                retval.Add(new ShareEntity() { DocID = allShares[row]["DOCID"] as string, UserInShare = allShares[row]["USERID"] as string });
            }
            return retval;
        }

        public ShareEntity Remove(ShareEntity shareToRemove)
        {
            throw new NotImplementedException();
        }
    }
}
