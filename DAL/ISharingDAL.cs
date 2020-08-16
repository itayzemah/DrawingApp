using EntityAndBoundary.Boundary;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface ISharingDAL
    {
        public ShareBoundary Create(ShareBoundary share);

        public ShareBoundary Remove(ShareBoundary shareToRemove);
    }
}
