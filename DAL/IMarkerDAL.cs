using EntityAndBoundary.Entitiy;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface IMarkerDAL
    {
        public MarkerEntity Create(MarkerEntity marker);

        public MarkerEntity Remove(string markerToRemove);

        public List<MarkerEntity> GetAllMarkersForDoc(string documentID);
    }
}
