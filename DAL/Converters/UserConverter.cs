﻿using AppContracts.DTO.Register;
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

        public UserEntity BoundaryToEntity(string id,RegisterRequest request)
        {
            return new UserEntity(id, request.register.Email, request.register.UserName);
        }
    }
}
