using Autofac;
using MarketingBox.TrafficEngine.Service.Grpc;

// ReSharper disable UnusedMember.Global

namespace MarketingBox.TrafficEngine.Service.Client
{
    public static class AutofacHelper
    {
        public static void RegisterEmailServiceClient(this ContainerBuilder builder, string grpcServiceUrl)
        {
            var factory = new ServiceClientFactory(grpcServiceUrl);

            builder.RegisterInstance(factory.GetTrafficEngineService()).As<ITrafficEngineService>().SingleInstance();
        }
    }
}
