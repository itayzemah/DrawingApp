using EntityAndBoundary.Boundary;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface IDocumentDAL
    {
        public DocumentBoundary Create(DocumentBoundary newDocument);

        public DocumentBoundary Remove(DocumentBoundary documentToRemove);

        public DocumentBoundary Get(string docID);

    }
}
