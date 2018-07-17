var project = "../test-redis-console/testRedisConsole.csproj";

Task("Default").Does(() =>
{
    Information("Hello World");
});

Task("Restore").Does(() => {
    DotNetCoreRestore(project);
});

Task("Build").Does(() =>
{
    CleanDirectory("build");
    Information("Building...");
    DotNetCoreBuild(project, new DotNetCoreBuildSettings {
        OutputDirectory = "build",
        Configuration = "Release"
    });
});

var target = Argument("target", "Default");
RunTarget(target);