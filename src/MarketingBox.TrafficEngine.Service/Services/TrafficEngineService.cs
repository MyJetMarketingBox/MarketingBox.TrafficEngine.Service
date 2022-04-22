using System.Threading.Tasks;
using MarketingBox.Sdk.Common.Models.Grpc;
using MarketingBox.TrafficEngine.Service.Grpc;

namespace MarketingBox.TrafficEngine.Service.Services
{
    public class TrafficEngineService : ITrafficEngineService
    {
        public Task<Response<bool>> AllocateAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}