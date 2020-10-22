using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppContracts.interfaces;
using EntityAndBoundary;
using EntityAndBoundary.Boundary;
using EntityAndBoundary.Marker_Response;
using ItayDrowingApp.AppContracts;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ItayDrowingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarkerController : ControllerBase
    {
        private IMarkerService markerService;
        private IWebSocketService webSocketService;

        public MarkerController(IMarkerService markerService, IWebSocketService webSocketService)
        {
            this.markerService = markerService;
            this.webSocketService = webSocketService;
        }




        // GET: api/<MarkerController>
        [HttpPost("for-document")]
        public IEnumerable<MarkerBoundary> GetAllMarkers([FromBody] DocumentID documentID)
        {
            return markerService.getAll(documentID.ID);
        }



        // POST api/<MarkerController>/create
        [HttpPost("create")]
        public MarkerBoundary Post([FromBody] MarkerBoundary marker)
        {
            var markerResult =  markerService.CreateMarker(marker);
            string merkerSerialized = JsonConvert.SerializeObject(markerResult);

            this.webSocketService.SendToAllLesteners(merkerSerialized,markerResult.docID);
            return markerResult;
        }

        // PUT api/<MarkerController>/remove
        [HttpPost("remove")]
        public Response<MarkerBoundary> RemoveMarker([FromBody] MarkerID markerID)
        {
            Response<MarkerBoundary> response = new RemoveMarkerResponseOK();
            response.ResponseData = markerService.RemoveMarker(markerID.ID);

            if(response.ResponseData == null)
            {
                response = new RemoveMarkerResponseNoMarker() {  Message ="No Such Marker"};
            }

            return response;
        }

        // DELETE api/<MarkerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
