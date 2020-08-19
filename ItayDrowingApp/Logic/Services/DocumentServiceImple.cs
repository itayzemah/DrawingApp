using DAL;
using DAL.Converters;
using EntityAndBoundary.Boundary;
using ItayDrowingApp.Logic.ServicesContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItayDrowingApp.Logic.Services
{
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
            throw new NotImplementedException();
        }

        public List<DocumentBoundary> getAll(string userEmail)
        {
            throw new NotImplementedException();
        }

        public DocumentBoundary RemoveDocument(DocumentBoundary document)
        {
            throw new NotImplementedException();
        }

        public DocumentBoundary UploadDocument(DocumentBoundary document, string userEmail)
        {
            throw new NotImplementedException();
        }
    }
}
