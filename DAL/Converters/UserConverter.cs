using EntityAndBoundary.Boundary;
using EntityAndBoundary.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DALImlementations
{
    public class UserConverter
    {
        public UserEntity BoundaryToEntity(UserBoundary user)
        {
            return new UserEntity(user.ID.ToString(), user.UserEmail, user.UserName);
        }

        public UserBoundary EntityToBoundary(UserEntity userEntity)
        {
            return new UserBoundary(userEntity.UserID, userEntity.userEmail, userEntity.UserName);
        }

        public UserEntity BoundaryToEntity(string id,NewUserBoundaey user)
        {
            return new UserEntity(id, user.Email, user.UserName);
        }
    }
}
