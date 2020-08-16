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
            return new DocumentEntity();
        }

        public DocumentBoundary EntityToBoundary(DocumentEntity userEntity)
        {
            return new DocumentBoundary();
        }
    }
}
