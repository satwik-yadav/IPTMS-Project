using AuthorizationAPI.Model;
using AuthorizationAPI.Provider;
using AuthorizationAPI.Repository;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace AuthTest
{
    public class Tests
    {
        List<User> user = new List<User>();
        
        [SetUp]
        public void Setup()
        {
            user = new List<User>()
            {
                new User{Username = "admin",Password = "admin"}
            };
            
        }


        [TestCase("admin","admin")]
        public void GetUser_Returns_userObject(string uname,string pass)
        {
            Mock<IUserProvider> mock = new Mock<IUserProvider>();
            mock.Setup(p => p.GetList()).Returns(user);
            UserProvider pro = new UserProvider();
            User cred = new User { Username = uname, Password = pass };

            User userCred = pro.GetUser(cred);

            Assert.IsNotNull(userCred);
        }

        [TestCase("user3", "user3")]
        public void GetUser_Returns_Null(string uname, string pass)
        {

            Mock<IUserProvider> mock = new Mock<IUserProvider>();
            mock.Setup(p => p.GetList()).Returns(user);
            UserProvider pro = new UserProvider();
            User cred = new User { Username = uname, Password = pass };

            User userCred = pro.GetUser(cred);

            Assert.IsNull(userCred);

        }

        
    }
}