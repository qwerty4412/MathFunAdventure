// Assets/Editor/CustomBuild.cs
using UnityEditor;
using System.Linq;

public class CustomBuild
{
    // The method we will call from the command line
    public static void PerformBuild()
    {
        // Define the output directory and file name
        string buildPath = "build/StandaloneWindows64/MathFunAdventure.exe";

        // Get the list of scenes included in the build settings
        string[] scenePaths = EditorBuildSettings.scenes
            .Where(scene => scene.enabled)
            .Select(scene => scene.path)
            .ToArray();

        // Define the build options
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = scenePaths;
        buildPlayerOptions.locationPathName = buildPath;
        buildPlayerOptions.target = BuildTarget.StandaloneWindows64;
        buildPlayerOptions.options = BuildOptions.None;

        // Perform the build
        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }
}