using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ST_CommuterWazeWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class CommuterWazeService : ICommuterWazeService
    {
        UserAccountManager userAccountManager = new UserAccountManager();
        PasswordManager passwordManager = new PasswordManager();
        RouteManager routeManager = new RouteManager();


        public AddUserResponse AddUser(AddUserRequest request)
        {
            AddUserResponse response = new AddUserResponse();
            response.Result = userAccountManager.AddUser(request.UserEntity);

            return response;
        }

        public RetrieveUserResponse RetrieveUser(RetrieveUserRequest request)
        {
            RetrieveUserResponse response = new RetrieveUserResponse();
            response.UserAccount = userAccountManager.GetUser(request.Username);

            return response;
        }

        public EncryptPasswordResponse EncryptPassword(EncryptPasswordRequest request)
        {
            EncryptPasswordResponse response = new EncryptPasswordResponse();
            string salt = string.Empty;
            response.HashPassword = passwordManager.GeneratePasswordHash(request.Password, out salt);
            response.Salt = salt;

            return response;
        }


        public PasswordMatchResponse PasswordMatch(PasswordMatchRequest request)
        {
            PasswordMatchResponse response = new PasswordMatchResponse();
            response.Result = passwordManager.IsPasswordMatch(request.Password, request.Salt, request.HashPassword);

            return response;
        }

        public AddPreferredRouteResponse AddPreferredRoute(AddPreferredRouteRequest request)
        {
            AddPreferredRouteResponse response = new AddPreferredRouteResponse();
            response.Result =  routeManager.AddPreferredRoute(request.PreferredRouteEntity);

            return response;
        }

        public RetrievePreferredRouteResponse RetrievePreferredRoute(RetrievePreferredRouteRequest request)
        {
            RetrievePreferredRouteResponse response = new RetrievePreferredRouteResponse();
            response.ListOfPreferredRouteEntity = routeManager.RetrievePreferredRoute(request.Username);

            return response;
        }
    }
}
