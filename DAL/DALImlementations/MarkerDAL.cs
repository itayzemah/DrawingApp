using EntityAndBoundary.Entitiy;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace DAL.DALImlementations
{
    public class MarkerDAL : IMarkerDAL
    {
        private IDataAccessLayer dal;

        public MarkerDAL(IDataAccessLayer dal)
        {
            this.dal = dal;
        }

        public MarkerEntity Create(MarkerEntity marker)
        {
            DbParameter[] dbParameters = {
                new OracleParameter() { ParameterName = "P_DOC_ID", Value = marker.docID}
                , new OracleParameter() { ParameterName = "P_MARKER_ID", Value = marker.MarkerID }
                , new OracleParameter() { ParameterName = "P_USER_ID",Value =marker.CreatedBy }
                , new OracleParameter() { ParameterName = "P_MARKER_TYPE",Value = marker.shape}
                , new OracleParameter() { ParameterName = "P_MARKER_LOCATION",Value = marker.LocationJson}
                , new OracleParameter() { ParameterName = "P_FORE_COLOR",Value = marker.ForeColor }
                , new OracleParameter() { ParameterName = "P_BACK_COLOR",Value = marker.BackColor }
                , new OracleParameter() {
                    ParameterName = "P_retval", OracleDbType = OracleDbType.RefCursor, Direction=System.Data.ParameterDirection.Output }
                 };
            var qResult = dal.ExecuteSPQuery(dal.Connect(dal.ConnectionString), "Add_marker_to_document", dbParameters);
            var mark = qResult.Tables[0].Rows[0];

            return new MarkerEntity()
            {
                MarkerID = mark["MarkerID"] as string,
                docID = mark["docID"] as string,
                CreatedBy = mark["USERID"] as string,
                LocationJson = mark["MARKERLOCATION"] as string,
                ForeColor = mark["FORE_COLOR"] as string,
                BackColor = mark["BACK_COLOR"] as string,
                shape = mark["MARKERTYPE"] as string
            };
        }

        public List<MarkerEntity> GetAllMarkersForDoc(string documentID)
        {
            List<MarkerEntity> rv = new List<MarkerEntity>() ;
            DbParameter[] dbParameters = {
                new OracleParameter() { ParameterName = "P_DOC_ID", Value = documentID},
                new OracleParameter() {
                    ParameterName = "P_retval", OracleDbType = OracleDbType.RefCursor, Direction=System.Data.ParameterDirection.Output }
                 };

            var qResult = dal.ExecuteSPQuery(dal.Connect(dal.ConnectionString), "GET_ALL_MARKERS_FOR_DOC", dbParameters);
            var allMarkersRows = qResult.Tables[0].Rows;
            for (int row = 0; row < allMarkersRows.Count; row++)
            {
                rv.Add(new MarkerEntity()
                {
                    MarkerID = allMarkersRows[row]["MARKERID"] as string,
                    docID = allMarkersRows[row]["DOCID"] as string,
                    shape = allMarkersRows[row]["MARKERTYPE"] as string,
                    LocationJson = allMarkersRows[row]["MARKERLOCATION"] as string,
                    CreatedBy = allMarkersRows[row]["USERID"] as string,
                    BackColor = allMarkersRows[row]["BACK_COLOR"] as string,
                    ForeColor = allMarkersRows[row]["FORE_COLOR"] as string
                });
            }
            return rv;
        }

        public MarkerEntity Remove(string markerToRemove)
        {
            MarkerEntity rv = null;
            DbParameter[] dbParameters = {
                new OracleParameter() { ParameterName = "p_markerid", Value = markerToRemove},
                new OracleParameter() {
                    ParameterName = "P_retval", OracleDbType = OracleDbType.RefCursor, Direction=System.Data.ParameterDirection.Output }
                 };

            var qResult = dal.ExecuteSPQuery(dal.Connect(dal.ConnectionString), "REMOVE_MARKER", dbParameters);
            try
            {
                var removedMarker = qResult.Tables[0].Rows[0];
                if (qResult.Tables[0].Rows.Count > 0)
                {
                    rv = new MarkerEntity()
                    {
                        MarkerID = removedMarker["MARKERID"] as string,
                        docID = removedMarker["DOCID"] as string,
                        shape = removedMarker["MARKERTYPE"] as string,
                        LocationJson = removedMarker["MARKERLOCATION"] as string,
                        CreatedBy = removedMarker["USERID"] as string,
                        BackColor = removedMarker["BACK_COLOR"] as string,
                        ForeColor = removedMarker["FORE_COLOR"] as string
                    };
                }
                return rv;
            }
            catch
            {
                return rv;
            }
           
        }
    }
}
