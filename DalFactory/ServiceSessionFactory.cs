using System.Runtime.Remoting.Messaging;
using IBll;
using IDal;

namespace DalFactory
{
    public class ServiceSessionFactory
    {
        public static IServiceSession GetCurrentServiceSession()
        {
            if (!(CallContext.GetData("ServiceSession") is IServiceSession service))
            {
                service = new ServiceSession();
                CallContext.SetData("ServiceContext", service);
            }

            return service;
        }
    }
}