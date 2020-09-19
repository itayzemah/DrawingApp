using DAL;
using DAL.Converters;
using EntityAndBoundary.Boundary;
using EntityAndBoundary.Entitiy;
using ItayDrowingApp.AppContracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ItayDrowingApp.Logic.Services
{
    [Register(Policy.Scoped, typeof(IDocumentService))]

    public class DocumentServiceImple : IDocumentService
    {
        private IDocumentDAL _documentDAL;
        private DocumentConverter _documentConverter;


        public DocumentServiceImple(IDocumentDAL documentDAL, DocumentConverter documentConverter)
        {
            this._documentDAL = documentDAL;
            this._documentConverter = documentConverter;
        }

        public DocumentBoundary CreateDocument(DocumentBoundary document, string userEmail)
        {
            document.docID = Guid.NewGuid().ToString();
            _documentDAL.Create(_documentConverter.BoundaryToEntity(document));
            return document;
        }

        public List<DocumentBoundary> getAll(string userEmail)
        {
            List<DocumentBoundary> rv = new List<DocumentBoundary>();
            var allDocs = _documentDAL.GetAllDocsOf(userEmail);
            foreach (var boundary in allDocs)
            {
                rv.Add(_documentConverter.EntityToBoundary(boundary));
            }
            return rv;
        }

        public DocumentBoundary RemoveDocument(DocumentID documentID)
        {
            var removedEntity= _documentDAL.Remove(documentID.ID);
            var rv = _documentConverter.EntityToBoundary(removedEntity);
            return rv;
        }

        public DocumentBoundary UploadDocument(DocumentBoundary document, string userEmail)
        {

            var entityToUpload = _documentConverter.BoundaryToEntity(document);
            var uploadedEntity = _documentDAL.Upload(entityToUpload);
            var rv = _documentConverter.EntityToBoundary(uploadedEntity);
            return rv;
        }
    }
}
