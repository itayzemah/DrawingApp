﻿using EntityAndBoundary.Boundary;
using ItayDrowingApp.AppContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItayDrowingApp.Logic.Services
{
    [Register(Policy.Scoped, typeof(IMarkerService))]
    public class MarkerServiceImple : IMarkerService
    {
        public MarkerBoundary CreateMarker(MarkerBoundary marker)
        {
            throw new NotImplementedException();
        }

        public List<MarkerBoundary> getAll(string userEmail, string docID)
        {
            throw new NotImplementedException();
        }

        public MarkerBoundary RemoveMarker(string docID)
        {
            throw new NotImplementedException();
        }
    }
}
