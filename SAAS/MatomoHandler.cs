using System;
using System.Threading.Tasks;

namespace SAAS
{
    public class MatomoHandler: IExperimentationHandler
    {
        //private matomo client
        public MatomoHandler(MatomoConfiguration config)
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
