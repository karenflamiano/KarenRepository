using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ST_CommuterWazeWebService
{
    public class UserAccountManager
    {
        PasswordManager passwordManager = new PasswordManager();
        public int AddUser(UserEntity userEntity)
        {
            UserAccount userAccount = new UserAccount();

            userAccount = Mapper.MapUserEntityToUserAccountTable(userEntity);

            int result = 0;
            using (var context = new CommuterWazeDBEntities())
            {
                try
                {
                    context.UserAccounts.Add(userAccount);
                    result = context.SaveChanges();
                }

                catch (Exception ex)
                {
                }
            }

            return result;
        }

        public UserEntity GetUser(string username)
        {
            UserEntity userEntity = new UserEntity();

            UserAccount userAccount = new UserAccount();

            using (var context = new CommuterWazeDBEntities())
            {
                try
                {
                    userAccount = context.UserAccounts.Single(u => u.Username == username);
                }

                catch
                {

                }
            }

            userEntity = Mapper.MapUserAccountTableToUserEntity(userAccount);

            return userEntity;
        }
    }
}