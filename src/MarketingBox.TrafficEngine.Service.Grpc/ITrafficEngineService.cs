using System.ServiceModel;
using System.Threading.Tasks;
using MarketingBox.Sdk.Common.Models.Grpc;

namespace MarketingBox.TrafficEngine.Service.Grpc;

[ServiceContract]
public interface ITrafficEngineService
{

    [OperationContract]
    Task<Response<bool>> AllocateAsync();
}