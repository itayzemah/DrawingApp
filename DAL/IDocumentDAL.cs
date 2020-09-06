using EntityAndBoundary.Boundary;
using EntityAndBoundary.Entitiy;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface IDocumentDAL
    {
        public DocumentEntity Create(DocumentEntity newDocument);

        public DocumentEntity Remove(DocumentEntity documentToRemove);

        public List<DocumentEntity> GetAllDocsOf(string userID);
        public DocumentEntity Upload(DocumentEntity entityToUpload);
    }
}
