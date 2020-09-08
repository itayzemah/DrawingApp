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
    public class MarkerController : ControllerBase
    {
        private IMarkerService markerService;

        public MarkerController(IMarkerService markerService)
        {
            this.markerService = markerService;
        }


        // GET: api/<MarkerController>
        [HttpGet("{userEmail}/{docID}")]
        public IEnumerable<MarkerBoundary> GetAllMarkers([FromRoute] string userEmail,string docID)
        {
            return markerService.getAll(userEmail, docID);
        }



        // POST api/<MarkerController>/create
        [HttpPost("create")]
        public MarkerBoundary Post([FromBody] MarkerBoundary marker)
        {
            return markerService.CreateMarker(marker);
        }

        // PUT api/<MarkerController>/5
        [HttpPut("remove/{docID}")]
        public void RemoveMarker([FromRoute] string docID)
        {
            markerService.RemoveMarker(docID);
        }

        // DELETE api/<MarkerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
