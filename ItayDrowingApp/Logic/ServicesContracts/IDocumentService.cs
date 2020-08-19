using EntityAndBoundary.Boundary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItayDrowingApp.Logic.ServicesContracts
{
    public interface IDocumentService
    {
        public DocumentBoundary CreateDocument(DocumentBoundary document,string userEmail);

        public DocumentBoundary UploadDocument(DocumentBoundary document, string userEmail);

        public DocumentBoundary RemoveDocument(DocumentBoundary document);

        public List<DocumentBoundary> getAll(string userEmail);



    }
}
