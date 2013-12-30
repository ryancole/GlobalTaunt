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
        private ISummonerService m_summoners;

        public SummonerServiceTests()
        {
            m_kernel = new StandardKernel();
            m_kernel.Load(Assembly.GetExecutingAssembly());

            m_summoners = m_kernel.Get<ISummonerService>();
            m_summoners.ApiKey = Settings1.Default.ApiKey;
        }

        #region Tests

        [TestMethod]
        public void CanGetById()
        {
            var summoner = m_summoners.Get(SummonerRegion.NA, 108);

            Assert.IsNotNull(summoner);
            Assert.IsTrue(summoner.Name == "ryancole");
        }

        [TestMethod]
        public void CanGetByName()
        {
            var summoner = m_summoners.Get(SummonerRegion.NA, "ryancole");

            Assert.IsNotNull(summoner);
            Assert.IsTrue(summoner.Id == 108);
        }

        #endregion
    }
}
