using System;
using System.Collections.Generic;
using System.Text;

namespace EntityAndBoundary.Entitiy
{
    public class DocumentEntity
    {
        public DocumentEntity(string ownerID, string uRL, string documentName, string docID, List<MarkerEntity> markers, Boolean isActive)
        {
            OwnerID = ownerID;
            URL = uRL;
            DocumentName = documentName;
            DocID = docID;
            Markers = markers;
            this.isActive = isActive;
        }

        public DocumentEntity(string ownerID, string uRL, string documentName, string docID, List<MarkerEntity> markers)
        {
            OwnerID = ownerID;
            URL = uRL;
            DocumentName = documentName;
            DocID = docID;
            Markers = markers;
        }

        public string OwnerID { get; set; }

        public string URL { get; set; }

        public string DocumentName { get; set; }

        public string DocID { get; set; }

        public List<MarkerEntity> Markers { get; set; }

        public Boolean isActive { get; set; }
    }
}
