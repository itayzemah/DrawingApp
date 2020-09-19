using EntityAndBoundary.Boundary;
using EntityAndBoundary.Entitiy;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Converters
{
    public class MarkerConverter
    {
        public MarkerBoundary FromEntity(MarkerEntity entity)
        {
            return new MarkerBoundary()
            {
                MarkerID = entity.MarkerID,
                docID = entity.docID,
                CreatedBy = entity.CreatedBy,
                LocationJson = entity.LocationJson,
                ForeColor = entity.ForeColor,
                BackColor = entity.BackColor,
                shape = entity.shape
            };
        }

        public MarkerEntity FromBoundary(MarkerBoundary boundary)
        {
            return new MarkerEntity()
            {
                MarkerID = boundary.MarkerID,
                docID = boundary.docID,
                CreatedBy = boundary.CreatedBy,
                LocationJson = boundary.LocationJson,
                ForeColor = boundary.ForeColor,
                BackColor = boundary.BackColor,
                shape = boundary.shape
            };
        }
    }
}
