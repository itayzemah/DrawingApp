using AppContracts;
using AppContracts.DTO.Share;
using DAL;
using EntityAndBoundary.Boundary;
using EntityAndBoundary.Entitiy;
using ItayDrowingApp.AppContracts;
using System;

using System.Threading.Tasks;

namespace ItayDrowingApp.Logic.Services
{
    [Register(Policy.Transient, typeof(ISharingService))]
    public class SharingServiceImple : ISharingService
    {
        private ISharingDAL sharingDAL;

        public SharingServiceImple(ISharingDAL sharingDAL)
        {
            this.sharingDAL = sharingDAL;
        }

        public Response CreateShare(CreateShareRequest request)
        {
            Response retval = default;
            var entityRV = sharingDAL.Create(new ShareEntity() { DocID = request.DocID, UserInShare = request.UserIDWantShare });
            retval = new CreateShareResponseOK() {Share = new ShareBoundary() { DocID = entityRV.DocID} };
            return retval;
        }

        public Response getAllSharedDocuments(GetSharedDocumentsResponseOK request)
        {
            throw new NotImplementedException();
        }

        public Response GetSharedUsers(GetSharedUsersRequest request)
        {
            throw new NotImplementedException();
        }

        public Response RemoveShare(RemoveShareRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
