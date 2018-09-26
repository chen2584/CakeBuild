#addin "Cake.WebDeploy"

var target = Argument("target", "Production");

Task("Production")
    .Description("Deploy to Azure using a custom Url")
    .Does(() =>
    {
        var settings = new DeploySettings()
        {
            SourcePath = @".\publish",
            PublishUrl = "https://localhost:8172/msdeploy.axd",
            SiteName = "AspNetCore",
            Username = "Chen",
            Password = ""
        };
        DeployWebsite(settings);
    });

Task("Default").IsDependentOn("Production");

RunTarget(target);