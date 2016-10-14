using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ST_CommuterWazeWebService
{
    [ServiceContract]
    public interface ICommuterWazeService
    {
        [OperationContract]
        AddUserResponse AddUser(AddUserRequest request);

        [OperationContract]
        AddPreferredRouteResponse AddPreferredRoute(AddPreferredRouteRequest request);

        [OperationContract]
        PasswordMatchResponse PasswordMatch(PasswordMatchRequest request);

        [OperationContract]
        RetrieveUserResponse RetrieveUser(RetrieveUserRequest request);

        [OperationContract]
        EncryptPasswordResponse EncryptPassword(EncryptPasswordRequest request);

        [OperationContract]
        RetrievePreferredRouteResponse RetrievePreferredRoute(RetrievePreferredRouteRequest request);

    }

}
