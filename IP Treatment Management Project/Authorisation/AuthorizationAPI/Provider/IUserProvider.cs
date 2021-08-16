using AuthorizationAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorizationAPI.Provider
{
    public interface IUserProvider
    {
        public List<User> GetList();

        public User GetUser(User cred);
    }
}
