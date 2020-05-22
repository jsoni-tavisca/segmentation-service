namespace SAAS
{
    public class OptimizelyConfiguration : Configuration
    {
        public OptimizelyConfiguration()
        {
            ToolName = "Optimizely";
        }
        public string SdkKey { get; set; }
    }
}
