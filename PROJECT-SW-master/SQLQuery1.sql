CREATE TABLE [dbo].[Worker]
(
	[Id] INT NOT NULL PRIMARY KEY identity(1,1), 
    [Fname] VARCHAR(50) NULL, 
    [Lname] VARCHAR(50) NULL, 
    [Age] INT NULL, 
    [Address] VARCHAR(200) NULL, 
    [SSN] NVARCHAR(50) NULL, 
    [PhoneNumber] NVARCHAR(50) NULL
)