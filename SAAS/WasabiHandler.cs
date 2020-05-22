using System;
using System.Threading.Tasks;

namespace SAAS
{
    public class WasabiHandler : IExperimentationHandler
    {
        //private wasabiClient;
        public WasabiHandler(WasabiConfiguration config)
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
