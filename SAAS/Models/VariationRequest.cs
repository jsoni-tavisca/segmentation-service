using System.Collections.Generic;

namespace SAAS
{
    public class VariationRequest
    {
        public string ExperimentKey { get; set; }
        public string UserId { get; set; }
        public string ProjectId { get; set; }
        public Dictionary<string, string> SegmentationRules { get; set; }
    }
}
