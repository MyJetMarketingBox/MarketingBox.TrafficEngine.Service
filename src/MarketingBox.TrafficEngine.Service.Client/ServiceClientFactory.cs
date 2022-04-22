using JetBrains.Annotations;
using MarketingBox.TrafficEngine.Service.Grpc;
using MyJetWallet.Sdk.Grpc;

namespace MarketingBox.TrafficEngine.Service.Client
{
    [UsedImplicitly]
    public class ServiceClientFactory : MyGrpcClientFactory
    {
        public ServiceClientFactory(string grpcServiceUrl) : base(grpcServiceUrl)
        {
        }

        public ITrafficEngineService GetTrafficEngineService() => CreateGrpcService<ITrafficEngineService>();
    }
}
