USE [master];
GO

IF DB_ID(N'CampusFacilitiesPortable') IS NULL
BEGIN
    RESTORE DATABASE [CampusFacilitiesPortable]
    FROM DISK =
        N'C:\Users\Daniel Truong\CampusFacilitiesBackup\CampusFacilitiesDB_before_packaging_20261105.bak'
    WITH
        FILE = 1,
        MOVE N'CampusFacilitiesDB'
            TO N'C:\Users\Daniel Truong\source\repos\Campus facilities\Campus facilities\Data\CampusFacilitiesDB.mdf',
        MOVE N'CampusFacilitiesDB_log'
            TO N'C:\Users\Daniel Truong\source\repos\Campus facilities\Campus facilities\Data\CampusFacilitiesDB.ldf',
        CHECKSUM,
        RECOVERY,
        STATS = 10;
END
ELSE
BEGIN
    PRINT 'Restore skipped: CampusFacilitiesPortable already exists. No restore was performed.';
END;
GO