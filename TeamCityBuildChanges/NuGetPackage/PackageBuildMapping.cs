﻿namespace TeamCityBuildChanges.NuGetPackage
{
    public class PackageBuildMapping
    {
        public string ServerUrl { get; set; }
        public string Project { get; set; }
        public string BuildConfigurationId { get; set; }
        public string BuildConfigurationName { get; set; }
        public string PackageId { get; set; }
    }
}
