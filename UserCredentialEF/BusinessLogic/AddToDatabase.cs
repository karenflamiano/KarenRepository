using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCredentialEF.BusinessLogic
{
    public class AddToDatabase
    {
        List<Exception> errorLogs = new List<Exception>();

        public bool AddUserToDB(TblUser user)
        {
            try
            {
                using (var context = new DBUserCredentialsEntities())
                {
                    context.TblUsers.Add(user);
                    return context.SaveChanges() > 0 ? true : false;

                }
            }

            catch (Exception ex)
            {
                errorLogs.Add(ex);
                return false;
            }
        }

    }
}
