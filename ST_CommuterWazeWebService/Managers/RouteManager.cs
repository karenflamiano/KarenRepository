using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ST_CommuterWazeWebService
{
    public class RouteManager
    {
        public int AddPreferredRoute(PreferredRouteEntity preferredRouteEntity)
        {
            int result = 0;
            PreferredRoute preferredRoute = new PreferredRoute();

            preferredRoute = Mapper.MapPreferredRouteEntityToPreferredRouteTable(preferredRouteEntity);
            using (var context = new CommuterWazeDBEntities())
            {
                try
                {
                    context.PreferredRoutes.Add(preferredRoute);
                    result = context.SaveChanges();
                }

                catch
                {
                }
            }

            return result;
        }

        public List<PreferredRouteEntity> RetrievePreferredRoute(string username)
        {
            List<PreferredRouteEntity> listOfPreferredRoute = new List<PreferredRouteEntity>();
            using (var context = new CommuterWazeDBEntities())
            {
                try
                {
                    var result = (List<PreferredRoute>)context.UserAccounts.Where(x => x.Username == username).Select(x => x.PreferredRoutes);

                    foreach (var preferredRoute in result)
                    {
                        listOfPreferredRoute.Add(new PreferredRouteEntity { PreferredRouteID = preferredRoute.PreferredRouteID, RouteID = preferredRoute.RouteID, Username = preferredRoute.Username });
                    }
                }

                catch
                {
                }
            }

            return listOfPreferredRoute;


        }
    }
}