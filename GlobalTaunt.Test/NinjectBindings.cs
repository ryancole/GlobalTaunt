using Ninject;
using Ninject.Modules;
using GlobalTaunt.Service;
using GlobalTaunt.Interface;

namespace GlobalTaunt.Test
{
    public class NinjectBindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IBaseService>().To<BaseService>();
            Bind<IGameService>().To<GameService>();
            Bind<ISummonerService>().To<SummonerService>();
        }
    }
}
