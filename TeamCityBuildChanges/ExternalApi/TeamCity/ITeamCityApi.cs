using System;
using System.Collections.Generic;

namespace TeamCityBuildChanges.ExternalApi.TeamCity
{
    public interface ITeamCityApi
    {
        string Url { get; }
        List<BuildType> GetBuildTypes();
        BuildTypeDetails GetBuildTypeDetailsById(string id);
        IEnumerable<Artifact> GetArtifactListByBuildType(string buildType);
        List<TeamCityApi.PackageDetails> GetNuGetDependenciesByBuildTypeAndBuildId(string buildType, string buildId);
        IEnumerable<ChangeDetail> GetChangeDetailsForLastBuildByBuildType(string buildType);
        Build GetLatestBuildByBuildType(string buildType);
        Build GetLatestSuccessfulBuildByBuildType(string buildType);
        IEnumerable<ChangeDetail> GetChangeDetailsByBuildId(string buildId);
        IEnumerable<ChangeDetail> GetChangeDetailsForCurrentBuildByBuildType(string buildType);
        IEnumerable<Build> GetRunningBuildByBuildType(string buildType);
        IEnumerable<BuildType> GetBuildTypeByProjectAndName(string project, string buildName);
        IEnumerable<Issue> GetIssuesByBuildTypeAndBuildRange(string buildType, string from, string to, IEnumerable<Build> buildList = null);
        IEnumerable<Issue> GetIssuesFromBuild(string buildId);
        IEnumerable<ChangeDetail> GetChangeDetailsByBuildTypeAndBuildId(string buildType, string from, string to, Func<Build, string, bool> comparitor, IEnumerable<Build> buildList = null);
        IEnumerable<ChangeDetail> GetChangeDetailsByBuildTypeAndBuildId(string buildType, string from, string to);
        IEnumerable<ChangeDetail> GetChangeDetailsByBuildTypeAndBuildNumber(string buildType, string from, string to, IEnumerable<Build> buildList = null);
        BuildDetails GetBuildDetailsByBuildId(string id);
        ChangeList GetChangeListByBuildId(string id);
        ChangeDetail GetChangeDetailsByChangeId(string id);
        IEnumerable<Build> GetBuildsByBuildType(string buildType);
    }
}