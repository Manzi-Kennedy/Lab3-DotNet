# TaskLink (WinForms + MySQL/XAMPP, MVC)
1. Start **Apache + MySQL** in the XAMPP Control Panel.
2. Open `TaskLink.csproj` (or the folder) in Visual Studio, restore NuGet packages, press F5.
   The database `tasklink` and its tables are created automatically on first run (`Database/tasklink.sql`).
3. Default admin: `admin@tasklink.com` / `Admin@123`.
If your MySQL root has a password, edit `Data/Db.cs` (`ServerPart`).
Folders: Models (data), Views (forms), Controllers (logic + SQL), Data (DB helper).
