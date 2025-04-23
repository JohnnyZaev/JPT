using VContainer;
using VContainer.Unity;

namespace Eredfall.JPT.Runtime.Bootstrap
{
    public class BootstrapEntryPoint : LifetimeScope, IStartable
    {
        protected override void Configure(IContainerBuilder builder)
        {
            base.Configure(builder);
        }

        public void Start()
        {
            throw new System.NotImplementedException();
        }
    }
}
