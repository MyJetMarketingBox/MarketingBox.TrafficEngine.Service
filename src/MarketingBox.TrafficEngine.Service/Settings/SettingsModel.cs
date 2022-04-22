using MyJetWallet.Sdk.Service;
using MyYamlParser;

namespace MarketingBox.TrafficEngine.Service.Settings
{
    public class SettingsModel
    {
        [YamlProperty("MarketingBoxTrafficEngineService.SeqServiceUrl")]
        public string SeqServiceUrl { get; set; }

        [YamlProperty("MarketingBoxTrafficEngineService.ZipkinUrl")]
        public string ZipkinUrl { get; set; }

        [YamlProperty("MarketingBoxTrafficEngineService.ElkLogs")]
        public LogElkSettings ElkLogs { get; set; }

        [YamlProperty("MarketingBoxTrafficEngineService.MyNoSqlReaderHostPort")]
        public string MyNoSqlReaderHostPort { get; set; }

        [YamlProperty("MarketingBoxTrafficEngineService.ExternalReferenceProxyServiceUrl")]
        public string ExternalReferenceProxyServiceUrl { get; set; }

        [YamlProperty("MarketingBoxTrafficEngineService.IntegrationServiceUrl")]
        public string IntegrationServiceUrl { get; set; }
    }
}
