    public class UnityDomainContainer : IContainer
    {
        private readonly IUnityContainer _unityContainer;

        public UnityDomainContainer(IUnityContainer unityContainer)
        {
            _unityContainer = unityContainer;
        }
        public T GetService<T>()
        {
            return _unityContainer.Resolve<T>();
        }

        public object GetService(Type serviceType)
        {
            return _unityContainer.Resolve(serviceType);
        }

        public IEnumerable<T> GetServices<T>()
        {
            return _unityContainer.ResolveAll<T>();
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _unityContainer.ResolveAll(serviceType);
        }
    }
