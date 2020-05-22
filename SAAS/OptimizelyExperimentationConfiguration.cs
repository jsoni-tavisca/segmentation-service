using System;
using System.Threading.Tasks;

namespace SAAS
{
    public class OptimizelyExperimentationConfiguration : IExperimentationConfiguration
    {
        public Task<IExperimentationHandler> Configure(string applicationName, string toolName)
        {
            throw new NotImplementedException();
        }
    }

}
