using EntityAndBoundary.Boundary;

namespace AppContracts.DTO.Login
{
    public class LoginResponse : Response
    {
        public UserBoundary User{ get; set; }
        public LoginResponse(UserBoundary user)
        {
            this.User = user;
        }
    }
}
