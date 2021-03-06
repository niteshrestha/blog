Title: Get. Set. Deploy
Lead: UWP development using Azure VM
Image: /posts/images/get-set-deploy.png
Published: 9/22/2017
Tags:
    - Microsoft
    - Windows 10
    - Visual Studio
    - UWP
    - Azure
RedirectFrom: get-set-deploy-5c5115833bb7
---

I was talking to a friend yesterday and he asked me if I had complied UWP app in Azure VM. I had compiled Windows 8.1 apps years ago but not UWP so I said no. I told him I would give it a try later on as I did not have internet access in my laptop at that time but waiting for that long was hard so I decided to do it from my lovely beloved Lumia. I already had Remote Desktop installed.

I logged into Azure Portal and fired up a Standard DS2_v2 Windows 10 VM I did not time this process. Once I had remote access to the VM I started timing it I went to Visual Studio website and downloaded the installer. I ran the installer and choose to install only the default Universal Windows Platform development workload. This would install Visual Studio core editor, Blend for Visual Studio, .NET Native, NuGet package manager, Universal Windows Platform tools, Windows 10 SDK 15063 and IntelliTrace. Install size was a little over 9 GB.

While Visual Studio was installing I went and downloaded the Kliva Solution from GitHub and extracted. It took about 10 minutes to complete the entire installation and Visual Studio was ready to launch. I launched Kliva.sln and I choose not to sign in, Visual Studio was preparing for first launch. Since I had only installed 15063 SDK Kliva solution did not load as it requires 14393 SDK so I closed Visual and installed 14393 SDK once done I launched Kliva project, enable Developer mode in Settings and choose x64 and clicked Local Machine and Visual Studio started restoring NuGet packages for the project, Build, Installing missing frameworks and Deploy. From first launch of Visual Studio to deploying Kliva app took another 8 minutes. In total it took about 18 minutes to go from nothing to being able to Build and Deploy in about 18 minutes.

Since Visual Studio 2017 allows you to install only what you need it's a benefit. Imagine doing this in previous versions of Visual Studio, INSTALL EVERYTHING EVEN IF YOU WILL NEVER USE IT. Now in my experience this was insanely fast as it takes me a lot more than 18 minutes to install Visual Studio in my i7 6th Gen, 8 GB machine. Am I the only one who thinks that this is insanely fast?
