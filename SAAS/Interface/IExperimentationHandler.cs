using System.Threading.Tasks;

namespace SAAS
{

    public interface IExperimentationHandler
    {
        
        Task<VariationResponse> GetVariation(VariationRequest request);
        Task SendImpression(ImpressionRequest request);
        Task SendMetric(MetricRequest request);
    }

}
