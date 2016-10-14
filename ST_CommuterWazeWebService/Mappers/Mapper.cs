using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ST_CommuterWazeWebService;

namespace ST_CommuterWazeWebService
{
    public static class Mapper
    {
        public static UserAccount MapUserEntityToUserAccountTable(UserEntity userEntity)
        {
            UserAccount userAccount = new UserAccount();

            userAccount.Username = userEntity.Username;
            userAccount.Salt = userEntity.Salt;
            userAccount.HashPassword = userEntity.HashPassword;

            return userAccount;
        }

        public static UserEntity MapUserAccountTableToUserEntity(UserAccount userAccount)
        {
            UserEntity userEntity = new UserEntity();

            userEntity.Username = userAccount.Username;
            userEntity.Salt = userAccount.Salt;
            userEntity.HashPassword = userAccount.HashPassword;

            return userEntity;
        }

        public static Route MapRouteEntityToRouteTable(RouteEntity routeEntity)
        {
            Route route = new Route();

            route.RouteID = routeEntity.RouteID;
            route.RouteName = routeEntity.Route;
            route.VehicleType = routeEntity.VehicleType;
            route.Fare = (decimal)routeEntity.Fare;

            return route;
        }

        public static RouteEntity MapRouteTableToRouteEntity(Route route)
        {
            RouteEntity routeEntity = new RouteEntity();

            routeEntity.RouteID = route.RouteID;
            routeEntity.Route = route.RouteName;
            routeEntity.VehicleType = route.VehicleType;
            routeEntity.Fare = (double)routeEntity.Fare;

            return routeEntity;
        }

        public static PreferredRoute MapPreferredRouteEntityToPreferredRouteTable(PreferredRouteEntity preferredRouteEntity)
        {
            PreferredRoute preferredRoute = new PreferredRoute();

            preferredRoute.PreferredRouteID = preferredRouteEntity.PreferredRouteID;
            preferredRoute.RouteID = preferredRouteEntity.RouteID;
            preferredRoute.Username = preferredRouteEntity.Username;

            return preferredRoute;
        }

        public static PreferredRouteEntity MapPreferredRouteTableToPreferredRouteEntity(PreferredRoute preferredRoute)
        {
            PreferredRouteEntity preferredRouteEntity = new PreferredRouteEntity();

            preferredRouteEntity.PreferredRouteID = preferredRoute.PreferredRouteID;
            preferredRouteEntity.RouteID = preferredRoute.RouteID;
            preferredRouteEntity.Username = preferredRoute.Username;

            return preferredRouteEntity;
        }
    }
}