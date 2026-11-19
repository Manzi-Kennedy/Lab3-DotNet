#Lab 3 :Desktop Application
## TaskLink (WinForms + MySQL/XAMPP, MVC)

### Student Name: MANZI Kennedy
### Student ID: 27600
### Course Name: DotNet
### Course ID: INSY 8411

1. Start **Apache + MySQL** in the XAMPP Control Panel.
2. Open `TaskLink.csproj` (or the folder) in Visual Studio, restore NuGet packages, press F5.
   The database `tasklink` and its tables are created automatically on first run (`Database/tasklink.sql`).
3. Default admin: `admin@tasklink.com` / `Admin@123`.
If your MySQL root has a password, edit `Data/Db.cs` (`ServerPart`).
Folders: Models (data), Views (forms), Controllers (logic + SQL), Data (DB helper).
