using EntityAndBoundary.Boundary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItayDrowingApp.Logic.ServicesContracts
{
    public interface ISharingService
    {
        public ShareBoundary CreateShare(List<UserBoundary> users);

        public List<DocumentBoundary> getAll();

        public ShareBoundary RemoveShare(ShareBoundary share);
    }
}
