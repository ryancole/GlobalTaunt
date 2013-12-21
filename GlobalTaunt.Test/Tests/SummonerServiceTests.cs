using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;
using GlobalTaunt.Model;
using GlobalTaunt.Service;
using GlobalTaunt.Interface;

namespace GlobalTaunt.Test
{
    [TestClass]
    public class SummonerServiceTests
    {
        private IKernel m_kernel;

        public SummonerServiceTests()
        {
            m_kernel = new StandardKernel();
            m_kernel.Load(Assembly.GetExecutingAssembly());
        }

        #region Tests

        [TestMethod]
        public void CanGetById()
        {
            var summoners = m_kernel.Get<ISummonerService>();
            var summoner = summoners.Get(Region.NA, 108);

            Assert.IsNotNull(summoner);
            Assert.IsTrue(summoner.Name == "ryancole");
        }

        [TestMethod]
        public void CanGetByName()
        {
            var summoners = m_kernel.Get<ISummonerService>();
            var summoner = summoners.Get(Region.NA, "ryancole");

            Assert.IsNotNull(summoner);
            Assert.IsTrue(summoner.Id == 108);
        }

        #endregion
    }
}
