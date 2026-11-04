USE [master];
GO

EXEC sp_detach_db
    @dbname = N'CampusFacilitiesPortable';
GO