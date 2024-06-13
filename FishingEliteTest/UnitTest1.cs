using FishingElite;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web;

namespace FishingEliteTest
{
    [TestClass]
    public class UnitTest1
    {
        MainFunctions mainFunctions = new MainFunctions();

        [TestMethod]
        public void authUserByEmailAndPassword()
        {
            string email = "misha@gmail.com";
            string password = "123";

            Assert.IsTrue(true);
            Assert.IsTrue(mainFunctions.auth(email, password));
        }

        [TestMethod]
        public void getActiveListFromDataBase()
        {
            bool IsNotEmpty = mainFunctions.getActive().Count > 0;
            Assert.IsTrue(true);
            Assert.IsTrue(IsNotEmpty);
        }

        [TestMethod]
        public void CreateActiveToDataBase()
        {
            bool IsSuccess = mainFunctions.createActive("Элитная рыбалка", 20, 1, "Лучшее что можно встретить!");
            Assert.IsTrue(true);
            Assert.IsTrue(IsSuccess);
        }

    }
}
