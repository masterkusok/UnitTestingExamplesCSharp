using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDB.Tests
{
    [TestClass()]
    public class UserDatabaseTests
    {
        public TestContext TestContext { get; set; }
        private UserDatabase _db = new UserDatabase();
        
        [TestMethod()]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "AddUserTestData.xml", "User",
            DataAccessMethod.Sequential)]
        public void AddUserTest()
        {
            // arrange
            User user = new User();
            user.Id = Convert.ToInt32(TestContext.DataRow["id"]);
            user.Name = Convert.ToString(TestContext.DataRow["name"]);
            user.Age = Convert.ToInt32(TestContext.DataRow["age"]);
            user.Email = Convert.ToString(TestContext.DataRow["email"]);

            // act
            bool successfully = _db.AddUser(user);

            // Assert
            Assert.IsTrue(successfully);
            
        }
    }
}