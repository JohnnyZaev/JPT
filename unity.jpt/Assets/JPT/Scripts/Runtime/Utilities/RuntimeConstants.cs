using UnityEngine.SceneManagement;

namespace Eredfall.JPT.Runtime.Utilities
{
    public static class RuntimeConstants
    {
        public static class Scenes
        {
            public static readonly int Bootstrap = SceneUtility.GetBuildIndexByScenePath("0.Bootstrap");
            public static readonly int Loading = SceneUtility.GetBuildIndexByScenePath("1.Loading");
            public static readonly int Meta = SceneUtility.GetBuildIndexByScenePath("2.Menu");
            public static readonly int Core = SceneUtility.GetBuildIndexByScenePath("3.Game");
            public static readonly int Empty = SceneUtility.GetBuildIndexByScenePath("4.Empty");
        }
    }
}