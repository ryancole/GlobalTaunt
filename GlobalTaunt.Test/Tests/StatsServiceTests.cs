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
    public class StatsServiceTests
    {
        private IKernel m_kernel;
        private IStatsService m_stats;

        public StatsServiceTests()
        {
            m_kernel = new StandardKernel();
            m_kernel.Load(Assembly.GetExecutingAssembly());

            m_stats = m_kernel.Get<IStatsService>();
            m_stats.ApiKey = Settings1.Default.ApiKey;
        }

        #region Tests

        [TestMethod]
        public void CanGetSummaryBySummoner()
        {
            var stats = m_stats.GetSummaryBySummoner(Region.NA, StatsSeason.SEASON3, 108);

            Assert.IsNotNull(stats);
            Assert.IsTrue(stats.Count > 0);
        }

        #endregion
    }
}
