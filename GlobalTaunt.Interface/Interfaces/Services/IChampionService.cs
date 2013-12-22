using System.Collections.Generic;
using GlobalTaunt.Model;

namespace GlobalTaunt.Interface
{
    public interface IChampionService : IBaseService
    {
        #region Methods

        /// <summary>
        /// Retrieve all champions
        /// </summary>
        IList<Champion> Get(Region region);

        #endregion
    }
}
