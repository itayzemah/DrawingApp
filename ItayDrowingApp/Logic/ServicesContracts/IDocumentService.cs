using ItayDrowingApp.Boundary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItayDrowingApp.Logic.ServicesContracts
{
    public interface IDocumentService
    {
        public DocumentBoundary CreateDocument(DocumentBoundary document);

        public DocumentBoundary UploadDocument(DocumentBoundary document);

        public DocumentBoundary RemoveDocument(DocumentBoundary document);

        public List<DocumentBoundary> getAll();



    }
}
