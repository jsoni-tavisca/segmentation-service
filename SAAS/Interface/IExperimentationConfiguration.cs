using System.Threading.Tasks;

namespace SAAS
{
    public interface IExperimentationConfiguration
    {
        Task<IExperimentationHandler> Configure(string applicationName, string toolName);         
    }
}
