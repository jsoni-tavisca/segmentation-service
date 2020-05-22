using System.Threading.Tasks;

namespace SAAS
{
    public interface IConfigurationManager
    {
        Task<Configuration> Get(string application, string toolName);
        Task<Configuration> Add(string application, Configuration tool);
        Task<Configuration> Update(string application, Configuration tool);
        Task<Configuration> Delete(string application, string toolName);
    }
}
