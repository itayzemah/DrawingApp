using EntityAndBoundary.Entitiy;
using EntityAndBoundary.Entity;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace DAL.DALImlementations
{

    public class DocumentDAL : IDocumentDAL
    {
        private readonly IDataAccessLayer _dal;

        public DocumentDAL(IDataAccessLayer dal)
        {
            this._dal = dal;
        }
        public DocumentEntity Create(DocumentEntity newDocument)
        {

            DbParameter[] dbParameters = {
                new OracleParameter() { ParameterName = "p_DOC_ID", Value = newDocument.DocID}
                , new OracleParameter() { ParameterName = "p_OWNER_ID", Value = newDocument.OwnerID }
                , new OracleParameter() { ParameterName = "p_URL",Value =newDocument.URL }
                , new OracleParameter() { ParameterName = "p_DOCUMENT_NAME",Value = newDocument.DocumentName}
                 };
            _dal.ExecuteSPQuery(_dal.Connect(_dal.ConnectionString), "ADD_DOCUMENT", dbParameters);
            return newDocument;
        }

        public List<DocumentEntity> GetAllDocsOf(string userID)
        {
            List<DocumentEntity> rv = new List<DocumentEntity>();
            DbParameter[] dbParameters = {
                new OracleParameter() { ParameterName = "OWNER_ID", Value = userID}
                , new OracleParameter() {
                    ParameterName = "ALL_DOCS", OracleDbType = OracleDbType.RefCursor, Direction=System.Data.ParameterDirection.Output }
                 };
            var qResult = _dal.ExecuteSPQuery(_dal.Connect(_dal.ConnectionString), "GET_ALL_DOCS_OF", dbParameters);
            var allDocsRows = qResult.Tables[0].Rows;
            for (int row = 0; row < allDocsRows.Count; row++)
            {
                rv.Add(new DocumentEntity(allDocsRows[row]["OWNER"] as string, allDocsRows[row]["IMAGEURL"] as string,
                                            allDocsRows[row]["DOCUMENTNAME"] as string,
                                                allDocsRows[row]["DOCID"] as string, null));
            }
            return rv;
        }

        public DocumentEntity Remove(string documentIDToRemove)
        {
            DbParameter[] dbParameters = {
                new OracleParameter() { ParameterName = "P_DOC_ID", Value = documentIDToRemove}
                , new OracleParameter() {
                    ParameterName = "P_retval", OracleDbType = OracleDbType.RefCursor, Direction=System.Data.ParameterDirection.Output }
                 };
            var qResult = _dal.ExecuteSPQuery(_dal.Connect(_dal.ConnectionString), "REMOVE_DOCUMENT", dbParameters);
            var documentRow = qResult.Tables[0].Rows[0];
            return new DocumentEntity(documentRow["OWNER"] as string, 
                documentRow["IMAGEURL"] as string, documentRow["DOCUMENTNAME"] as string, 
                documentRow["DOCID"] as string, null);
        }

        public DocumentEntity Upload(DocumentEntity entityToUpload)
        {
            throw new NotImplementedException();
        }
    }
}
