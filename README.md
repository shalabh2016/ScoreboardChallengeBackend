# Scoreboard Challenge Backend

To start the backend just follow:
+ Download the git repo
+ Please ensure that you have dot net 3.1 is installed. (I have provided the link of the download page.)
+ Run `dotnet restore` (To restore nuget packages)
+ Run `dotnet run`
+ The server will start at `https://localhost:5001`.

## Database

I have included SQLite database `playerpointdb.db` with the repo. There are sample Player Names and Points ready. But if you want to an empty database then please follow these steps:

+ Delete `playerpointdb.db`

**If you do not have *dotnet ef* commands installed then for windows please follow these steps:**
+ `dotnet tool install --global dotnet-ef`
+ `dotnet ef database update`

**Otherwise:**
+ `dotnet ef database update` to Update the migrations.

## If you do not have dotnet 3.1 installed: 
+ Please see the instuctions: https://dotnet.microsoft.com/download/dotnet-core/3.1

## The Client Side: https://github.com/shalabh2016/ScoreboardChallengeClient

## Stack:
+ .Net Core 3.1 (Web Api)
+ SQL Lite
