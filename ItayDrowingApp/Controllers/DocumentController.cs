using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityAndBoundary.Boundary;
using ItayDrowingApp.AppContracts;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ItayDrowingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        private IDocumentService documentService;

        public DocumentController(IDocumentService documentService)
        {
            this.documentService = documentService;
        }


        // GET: api/document/{userEmail}
        [HttpGet("{userEmail}")]
        public IEnumerable<DocumentBoundary> GetAllDocuments([FromRoute] string userEmail)
        {
            return documentService.getAll(userEmail);
        }



        // POST api/document/{userEmail}
        [HttpPost("{userEmail}")]
        public DocumentBoundary CreateDocument([FromRoute] string userEmail,[FromBody] DocumentBoundary documentBoundary)
        {
            return documentService.CreateDocument(documentBoundary, userEmail);
        }

        // POST api/document/{userEmail}/upload
        [HttpPost]
        [Route("api/document/{userEmail}/upload")]
        public DocumentBoundary UploadDocument([FromRoute] string userEmail, [FromBody] DocumentBoundary documentBoundary)
        {
            return documentService.UploadDocument(documentBoundary, userEmail);
        }

        // PUT api/<DocumentController>/remove
        [HttpPut("remove")]
        public void Put([FromBody] DocumentBoundary documentBoundary)
        {
            documentService.RemoveDocument(documentBoundary);
        }


    }
}
