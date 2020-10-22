using AppContracts.DTO.Marker;
using AppContracts.interfaces;
using DAL;
using DAL.Converters;
using EntityAndBoundary;
using EntityAndBoundary.Boundary;
using EntityAndBoundary.Entitiy;
using ItayDrowingApp.AppContracts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ItayDrowingApp.Logic.Services
{
    [Register(Policy.Singleton, typeof(IMarkerService))]
    public class MarkerServiceImple : IMarkerService
    {
        private IMarkerDAL markerDAL;
        private IWebSocketService webSocketService;
        private IDocumentDAL documentDAL;
        private MarkerConverter converter;

        public MarkerServiceImple(IMarkerDAL markerDAL, IWebSocketService webSocketService, MarkerConverter converter)
        {
            this.markerDAL = markerDAL;
            this.webSocketService = webSocketService;
            this.converter = converter;
        }

        public MarkerBoundary CreateMarker(MarkerBoundary marker)
        {
            marker.MarkerID = Guid.NewGuid().ToString();
            MarkerEntity entity = converter.FromBoundary(marker);
            try
            {
                entity = markerDAL.Create(entity);
                string message = JsonConvert.SerializeObject(entity);
            }
            catch
            { }
            return converter.FromEntity(entity);
        }

        public MarkerBoundary[] getAll(string ID)
        {
            var markers = this.markerDAL.GetAllMarkersForDoc(ID);
            MarkerBoundary[] retval = new MarkerBoundary[markers.Count];
            for (int i = 0; i < markers.Count; i++)
            {
                retval[i] = converter.FromEntity(markers[i]);
            }
            return retval;
        }

        public MarkerBoundary RemoveMarker(string markerID)
        {
            var marker = this.markerDAL.Remove(markerID);
            MarkerBoundary retval = null;
            if (marker != null)
            {
                retval = converter.FromEntity(marker);
            }
            return retval;
        }

    }
}
