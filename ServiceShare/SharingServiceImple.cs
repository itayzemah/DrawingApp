using EntityAndBoundary.Boundary;
using ItayDrowingApp.AppContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItayDrowingApp.Logic.Services
{
    [Register(Policy.Scoped, typeof(ISharingService))]
    public class SharingServiceImple : ISharingService
    {
        public ShareBoundary CreateShare(List<UserBoundary> users)
        {
            throw new NotImplementedException();
        }

        public List<DocumentBoundary> getAll()
        {
            throw new NotImplementedException();
        }

        public ShareBoundary RemoveShare(ShareBoundary share)
        {
            throw new NotImplementedException();
        }
    }
}
