# Task Manager Lite (TMGRLite)

## Brief intro
A lightweight alternative to the original Windows(R) task manager, made with the concern that the original task manager is getting slow **(on low end devices)** and often does not respond several seconds after launch which also took some time before executing.
The delayed launch and unresponsiveness is sometimes annoying as you may want to close an unresponsive app / `process` as it takes up your precious time. We realized that this poor performance of the original Task Manager may be due to the fact that it contains some extra features apart from just loading a list of apps and enabling users to close apps and processes quickly. **Task Manager** is full of other features that also use up resources such as the performance **graphs,** load other users usage statistics, get **CPU** details and more. Yes this features are cool but for a low-end machine they may cause lag and also not everybody goes into details, some just use it to close unresponsive apps, especially low-end machine users. As a low end device user myself I had to come up with a solution. **Task Manager Lite**
## User Guide
- [x] Very simple and lightweight.
> I don't know why I had to write a user guide. :smile:

Click an item (app) in the list, and use the preferred action in the buttons at the bottom. The buttons text content clearly states what it does when clicked. The task to be stopped is the task whose name is in the bottom left next to the buttons.
![Screenshot of TMGRLite running on Windows 10]("tmgr-bg-processes.PNG")
## Features
- [x] Close apps and processes
- [x] Force close unresponsive apps and processes
- [x] Refresh apps/processes
- [x] Get process details
- [x] Close all running processes (experimental)
### TODO:
- [ ] Load running processes in real-time instead of manually refreshing the list
- [ ] Add a search bar to easily find processes
      - By Process Id
      - By process Name
- [ ]  Separate tab for unresponsive processes/apps
- [ ] ### Optional
        - Migrate to C++ as it is said to be faster
        - Android Version
# Developers
Requires .NET framework and `WinForms`
Visual Studio 2019 or later with C# support installed.
## Contributing
The code in this repo is only the important task manager code, the `.sln` file is not available for some reasons.
As such, contributing involves creating your own project with same `namespace` as this one in C# and downloading the raw file of `Form1.cs` , modifying and testing on your local machine then committing only the new (yours) `Form1.cs` file.
Ensure to comment your code well and outline the steps involved.
### OR
You can download the original `Form1.cs` , create a project, copy the code to your project and modify it accordingly then commit your entire project to this repo.
