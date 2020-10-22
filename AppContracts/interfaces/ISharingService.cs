using AppContracts;
using AppContracts.DTO.Share;
using EntityAndBoundary.Boundary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItayDrowingApp.AppContracts
{
    public interface ISharingService
    {
        public Response CreateShare(CreateShareRequest request);

        public Response getAllSharedDocuments(GetSharedDocumentsResponseOK request);
        public Response GetSharedUsers(GetSharedUsersRequest request);

        public Response RemoveShare(RemoveShareRequest request);
    }
}
