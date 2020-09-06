using EntityAndBoundary.Boundary;
using System;
using System.Collections.Generic;
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

        public MarkerBoundary Create(MarkerBoundary marker)
        {
            throw new NotImplementedException();
        }

        public MarkerBoundary GetAllMarkersForDoc(string documentID)
        {
            throw new NotImplementedException();
        }

        public MarkerBoundary Remove(MarkerBoundary markerToRemove)
        {
            throw new NotImplementedException();
        }
    }
}
