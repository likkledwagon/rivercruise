delete from Ship2Company
go
delete from Crews
go
delete from Ships
go
delete from Reports;
go
delete from Agents;
go
delete from Companies;
go
DBCC CHECKIDENT (Ship2Company, RESEED,0);
DBCC CHECKIDENT (Crews, RESEED,0);
DBCC CHECKIDENT (Ships, RESEED,0);
DBCC CHECKIDENT (Reports, RESEED,0);
DBCC CHECKIDENT (Agents, RESEED,0);
DBCC CHECKIDENT (Companies, RESEED,0);