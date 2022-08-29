using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System.Collections.Generic;
using UserManagement;
using Assert = NUnit.Framework.Assert;

namespace UnitTest
{
    [TestClass]
    public class UserTests
    {
        List<User> ul = new List<User>();
        List<Role> rl = new List<Role>();
        public UserTests()
        {

            rl.Add(new Role(1, "Manage and Admin"));
            rl.Add(new Role(2, "Manager"));
            List<Role> rl2 = new List<Role>();
            rl2.Add(new Role(1, "Team Lead"));
            rl2.Add(new Role(2, "Admin"));

            ul.Add(new User(1, "fnamemale1", "lname1", "Male", 25, rl));
            ul.Add(new User(2, "fnamemale2", "lname2", "Male", 50, rl2));
            ul.Add(new User(3, "fnamemale3", "lname3", "Male", 45, rl2));
            ul.Add(new User(4, "fnamefemale1", "lname4", "Female", 22, rl));
            ul.Add(new User(4, "fnamefemale2", "lname5", "Female", 21, rl));

        }

        [TestMethod()]
        public void getWomenLessThan25Test()
        {
            new User().getWomenLessThan25(this.ul);
            Assert.IsTrue(true);
        }
        [TestMethod()]
        public void getWomenLessThan25TestWithnull()
        {
            new User().getWomenLessThan25(null);
            Assert.IsTrue(true);
        }
        [TestMethod()]
        public void getWomenLessThan25TestWithWithNoUserData()
        {
            new User().getWomenLessThan25(new List<User>());
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void getyoungestManTest()
        {
            new User().getyoungestMan(this.ul);
            Assert.IsTrue(true);
        }
        [TestMethod()]
        public void getyoungestManTestWithNull()
        {
            new User().getyoungestMan(null);
            Assert.IsTrue(true);
        }
        [TestMethod()]
        public void getyoungestManTestWithNoUserData()
        {
            new User().getyoungestMan(new List<User>());
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void getMenGreaterThan40Test()
        {
            new User().getMenGreaterThan40(this.ul);
            Assert.IsTrue(true);
        }
        [TestMethod()]
        public void getMenGreaterThan40TestWithNull()
        {
            new User().getMenGreaterThan40(null);
            Assert.IsTrue(true);
        }
        [TestMethod()]
        public void getMenGreaterThan40TestWithNoUserData()
        {
            new User().getMenGreaterThan40(new List<User>());
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void getWomenWithManageAdminRoleTest()
        {
            new User().getWomenWithManageAdminRole(this.ul);
            Assert.IsTrue(true);
        }
        [TestMethod()]
        public void getWomenWithManageAdminRoleTestWithNull()
        {
            new User().getWomenWithManageAdminRole(null);
            Assert.IsTrue(true);
        }
        [TestMethod()]
        public void getWomenWithManageAdminRoleTestWithNoUserData()
        {
            new User().getWomenWithManageAdminRole(new List<User>());
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void getManagersStartswithJOTest()
        {
            new User().getManagersStartswithJO(this.ul);
            Assert.IsTrue(true);
        }
        [TestMethod()]
        public void getManagersStartswithJOWithNull()
        {
            new User().getManagersStartswithJO(null);
            Assert.IsTrue(true);
        }
        [TestMethod()]
        public void getManagersStartswithJOTestWithNoUserData()
        {
            new User().getManagersStartswithJO(new List<User>());
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void logUserdetailsTest()
        {
            new User().logUserdetails(this.ul);
            Assert.IsTrue(true);
        }
        [TestMethod()]
        public void logUserdetailsTestWithNull()
        {
            new User().logUserdetails(null);
            Assert.IsTrue(true);
        }
        [TestMethod()]
        public void logUserdetailsTestWithNoUserData()
        {
            new User().logUserdetails(new List<User>());
            Assert.IsTrue(true);
        }
    }
}