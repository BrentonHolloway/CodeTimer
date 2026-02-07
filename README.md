# CodeTimer
A privacy focused timer to track your coding sessions.

# Create migration
Add-Migration <MigrationName> -Project CodeTimer.DataAccess -StartupProject CodeTimer.UI

# Remove latest migration
Remove-Migration -Project CodeTimer.DataAccess -StartupProject CodeTimer.UI

# Update database to the latest migration
Update-Database -Project CodeTimer.DataAccess -StartupProject CodeTimer.UI

# Update database to specific migration (Including rolling back)
Update-Database <MigrationName> -Project CodeTimer.DataAccess -StartupProject CodeTimer.UI'
