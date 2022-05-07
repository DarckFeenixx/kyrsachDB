CREATE LOGIN kyrsach WITH PASSWORD = '1pq0!PQ)'
GO
ALTER SERVER ROLE [dbcreator] ADD MEMBER [kyrsach]
GO
ALTER SERVER ROLE [securityadmin] ADD MEMBER [kyrsach]
GO