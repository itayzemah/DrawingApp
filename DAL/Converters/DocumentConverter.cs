using EntityAndBoundary.Boundary;
using EntityAndBoundary.Entitiy;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Converters
{
    public class DocumentConverter
    {

        public DocumentEntity BoundaryToEntity(DocumentBoundary user)
        {
            return new DocumentEntity(user.OwnerID, user.URL, user.DocumentName, user.docID, this.BoundaryToEntity(user.Markers));
        }

        private List<MarkerEntity> BoundaryToEntity(MarkerBoundary[] markers)
        {
            List<MarkerEntity> rv = new List<MarkerEntity>();
            return rv;
        }

        public DocumentBoundary EntityToBoundary(DocumentEntity userEntity)
        {
            return new DocumentBoundary()
            {
                docID = userEntity.DocID,
                URL = userEntity.URL,
                DocumentName = userEntity.DocumentName,
                IsActive = userEntity.isActive,
                OwnerID = userEntity.OwnerID
            };
        }

        //private MarkerBoundary[] EntityToBoundary(List<MarkerEntity> markers)
        //{
        //    int size = 5;
        //    MarkerBoundary[] rv = new MarkerBoundary[size];
        //    for (int m = 0; m < size; m++)
        //    {
        //        MarkerBoundary boundary = new MarkerBoundary();//TODO create marker here
        //        rv[m] = boundary;
        //    }
        //    return rv;
        //}
    }
}
