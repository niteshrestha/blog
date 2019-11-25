#addin nuget:?package=Cake.Powershell&version=0.4.8

var RootDir = MakeAbsolute(Directory(".")); 
var buildtarget = Argument("target", "Default");

Task("Build")
    .Does(() => StartProcess("wyam"));

Task("Preview")
    .Does(() => StartProcess("wyam", "preview"));

Task("Deploy")
    .IsDependentOn("Build")
    .Does(() => 
    {
        if(FileExists("./CNAME"))
            CopyFile("./CNAME", "output/CNAME");

        StartProcess("git", "checkout master");
        StartProcess("git", "add .");
        StartProcess("git", "commit -m \"Checking output in for subtree\"");
        StartProcess("git", "subtree split --prefix output -b gh-pages");
        StartProcess("git", "push -f origin gh-pages:gh-pages");
        StartProcess("git", "branch -D gh-pages");

    });

RunTarget(buildtarget);