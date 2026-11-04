USE [CampusFacilitiesDB];

SELECT 
name AS LogicalName,
type_desc AS FileType,
physical_name AS FileLocation

FROM sys.database_files;


SELECT
SERVERPROPERTY('ProductVersion') AS SQLServerVersion,
SERVERPROPERTY('Edition') AS SQLServerEdition;