using EntityAndBoundary.Boundary;
using EntityAndBoundary.Entitiy;
using System.Collections.Generic;

namespace DAL
{
    public interface ISharingDAL
    {
        public ShareEntity Create(ShareEntity share);

        public ShareEntity Remove(ShareEntity shareToRemove);

        public List<ShareEntity> GetShareByUser(string userID);
    }
}
