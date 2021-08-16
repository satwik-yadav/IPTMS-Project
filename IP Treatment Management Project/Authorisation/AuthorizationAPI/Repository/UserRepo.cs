using AuthorizationAPI.Model;
using AuthorizationAPI.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorizationAPI.Repository
{
    public class UserRepo : IUserRepo
    {
        private IUserProvider provider;

        public UserRepo(IUserProvider _provider)
        {
            provider = _provider;
        }
        public User GetUserCred(User cred)
        {
            if(cred == null)
            {
                return null;
            }

            User user = provider.GetUser(cred);

            return user;
        }
    }
}
