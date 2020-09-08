using EntityAndBoundary.Boundary;
using System.Collections.Generic;


namespace ItayDrowingApp.AppContracts
{
    public interface IDocumentService
    {
        public DocumentBoundary CreateDocument(DocumentBoundary document,string userEmail);

        public DocumentBoundary UploadDocument(DocumentBoundary document, string userEmail);

        public DocumentBoundary RemoveDocument(DocumentBoundary document);

        public List<DocumentBoundary> getAll(string userEmail);



    }
}
