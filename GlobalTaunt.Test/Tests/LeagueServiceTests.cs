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
    public class LeagueServiceTests
    {
        private IKernel m_kernel;
        private ILeagueService m_leagues;

        public LeagueServiceTests()
        {
            m_kernel = new StandardKernel();
            m_kernel.Load(Assembly.GetExecutingAssembly());

            m_leagues = m_kernel.Get<ILeagueService>();
            m_leagues.ApiKey = Settings1.Default.ApiKey;
        }

        #region Tests

        [TestMethod]
        public void CanGet()
        {
            var leagues = m_leagues.Get(SummonerRegion.NA, 108);

            Assert.IsNotNull(leagues);
            Assert.IsTrue(leagues.Count > 0);
        }

        #endregion
    }
}
