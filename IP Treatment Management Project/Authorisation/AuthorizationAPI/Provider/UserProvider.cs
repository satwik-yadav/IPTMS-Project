using AuthorizationAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorizationAPI.Provider
{
    public class UserProvider : IUserProvider
    {
        private static List<User> List = new List<User>()
        {
            new User{ Username = "admin", Password = "admin"}
        };
        public List<User> GetList()
        {
            return List;
        }

        public User GetUser(User cred)
        {
            List<User> rList = GetList();
            User userCred = rList.FirstOrDefault(user => user.Username == cred.Username && user.Password == cred.Password);

            return userCred;
        }
    }
}
