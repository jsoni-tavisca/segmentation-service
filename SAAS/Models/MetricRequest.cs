﻿using System.Collections.Generic;

namespace SAAS
{
    public class MetricRequest  //Empty Response OK
    {
        public string ExperimentKey { get; set; }
        public string VariationName { get; set; }
        public string UserId { get; set; }
        public string SiteId { get; set; }
        public Dictionary<string, string> SegmentationRules { get; set; }
        public Dictionary<string, string> EventTags { get; set; }
        public string EventName { get; set; }
    }
}
