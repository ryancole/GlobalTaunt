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
    public class GameServiceTests
    {
        private IKernel m_kernel;
        private IGameService m_games;

        public GameServiceTests()
        {
            m_kernel = new StandardKernel();
            m_kernel.Load(Assembly.GetExecutingAssembly());

            m_games = m_kernel.Get<IGameService>();
            m_games.ApiKey = Settings1.Default.ApiKey;
        }

        #region Tests

        [TestMethod]
        public void CanGetRecent()
        {
            var games = m_games.GetRecent(SummonerRegion.NA, 108);

            Assert.IsNotNull(games);
            Assert.IsTrue(games.Count > 0);
        }

        #endregion
    }
}
