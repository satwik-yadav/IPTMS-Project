using AuthorizationAPI.Model;
using AuthorizationAPI.Provider;
using AuthorizationAPI.Repository;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthTest
{
    class RepoAuthTest
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


        [TestCase("admin", "admin")]
        public void GetUserCred_Returns_Object(string uname, string pass)
        {
            User cred = new User { Username = uname, Password = pass };
            Mock<IUserRepo> mock = new Mock<IUserRepo>();
            mock.Setup(p => p.GetUserCred(cred)).Returns(user[0]);

            User userCred = mock.Object.GetUserCred(cred);

            Assert.IsNotNull(userCred);
        }

       
        [TestCase("user3", "user3")]
        public void GetUserCred_Returns_Null(string uname, string pass)
        {
            user[0] = null;
            User cred = new User { Username = uname, Password = pass };
            Mock<IUserRepo> mock = new Mock<IUserRepo>();
            mock.Setup(p => p.GetUserCred(cred)).Returns(user[0]);
               
            User userCred = mock.Object.GetUserCred(cred);

            Assert.IsNull(userCred);

        }
    }
}
