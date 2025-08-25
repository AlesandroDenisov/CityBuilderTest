using CityBuilder.Application;
using MessagePipe;
using VContainer;
using VContainer.Unity;

namespace CityBuilder.Infrastructure.DI
{
    public class GameLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            var options = builder.RegisterMessagePipe();
            builder.RegisterBuildCallback(c => GlobalMessagePipe.SetProvider(c.AsServiceProvider()));
            
            //builder.Register<GridService>(Lifetime.Singleton);
        }
    }
}
