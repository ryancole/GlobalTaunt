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
    public class ChampionServiceTests
    {
        private IKernel m_kernel;
        private IChampionService m_champions;

        public ChampionServiceTests()
        {
            m_kernel = new StandardKernel();
            m_kernel.Load(Assembly.GetExecutingAssembly());

            m_champions = m_kernel.Get<IChampionService>();
            m_champions.ApiKey = Settings1.Default.ApiKey;
        }

        #region Tests

        [TestMethod]
        public void CanGet()
        {
            var champions = m_champions.Get(Region.NA);

            Assert.IsNotNull(champions);
            Assert.IsTrue(champions.Count > 0);
        }

        #endregion
    }
}
