using RestSharp;
using GlobalTaunt.Model;

namespace GlobalTaunt.Interface
{
    public interface IBaseService
    {
        #region Methods

        T Execute<T>(IRestRequest request) where T : new();

        #endregion
    }
}
