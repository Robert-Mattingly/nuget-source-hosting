# nuget-source-hosting
An example project demonstrating how to host a NuGet package repo in source when a central server isn't feasible.

## Purpose
There have been several occasions where maintaining indirect project dependencies through NuGet packages was a 
better design choice than a direct project reference between projects in a Visual Studio solution.  There was 
*however*, rarely a centrally available private NuGet server for team use.  This project is part of a 
demonstration for a simple workaround using source to maintain package access and the local file system to host 
a NuGet repo.
