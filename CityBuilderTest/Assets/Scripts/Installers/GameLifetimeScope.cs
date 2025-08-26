using MessagePipe;
using VContainer;
using VContainer.Unity;

namespace CityBuilder.Infrastructure.DI
{
    public class GameLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            MessagePipeOptions options = builder.RegisterMessagePipe();
            builder.RegisterBuildCallback(c => GlobalMessagePipe.SetProvider(c.AsServiceProvider()));
            
            //builder.Register<GridService>(Lifetime.Singleton);
        }
    }
}
