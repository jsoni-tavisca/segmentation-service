using System;
using System.Threading.Tasks;

namespace SAAS
{
    public class OptimizelyHandler : IExperimentationHandler
    {
        //private optimizelyClient;
        public OptimizelyHandler(OptimizelyConfiguration config)
        {

        }

        public Task<VariationResponse> GetVariation(VariationRequest request)
        {
            throw new NotImplementedException();
        }

        public Task SendImpression(ImpressionRequest request)
        {
            throw new NotImplementedException();
        }

        public Task SendMetric(MetricRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
