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
    public class TeamServiceTests
    {
        private IKernel m_kernel;
        private ITeamService m_teams;

        public TeamServiceTests()
        {
            m_kernel = new StandardKernel();
            m_kernel.Load(Assembly.GetExecutingAssembly());

            m_teams = m_kernel.Get<ITeamService>();
            m_teams.ApiKey = Settings1.Default.ApiKey;
        }

        #region Tests

        [TestMethod]
        public void CanGetBySummoner()
        {
            var teams = m_teams.GetBySummoner(SummonerRegion.NA, 5908);

            Assert.IsNotNull(teams);
            Assert.IsTrue(teams.Count > 0);
        }

        #endregion
    }
}
