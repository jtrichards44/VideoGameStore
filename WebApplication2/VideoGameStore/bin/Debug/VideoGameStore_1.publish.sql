﻿/*
Deployment script for VideoGameStore

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "VideoGameStore"
:setvar DefaultFilePrefix "VideoGameStore"
:setvar DefaultDataPath "C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\"
:setvar DefaultLogPath "C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Altering [dbo].[VideoGames]...';


GO
ALTER TABLE [dbo].[VideoGames] ALTER COLUMN [ReleasedDate] DATE NOT NULL;


GO
INSERT INTO Ratings VALUES (1, 'Teen')
INSERT INTO Ratings VALUES (2, 'Everyone')
INSERT INTO Ratings VALUES (3, 'Mature')


 INSERT INTO Platforms VALUES('Switch')
 INSERT INTO Platforms VALUES('WiiU')
 INSERT INTO Platforms VALUES('Wii')
 INSERT INTO Platforms VALUES('GameCube')
 INSERT INTO Platforms VALUES('N64')
 INSERT INTO Platforms VALUES('Playstation')
 INSERT INTO Platforms VALUES('Playstation2')
 INSERT INTO Platforms VALUES('Playstation3')
 INSERT INTO Platforms VALUES('Playstation4')
 INSERT INTO Platforms VALUES('Xbox')
 INSERT INTO Platforms VALUES('Xbox360')
 INSERT INTO Platforms VALUES('XboxOne')
 INSERT INTO Platforms VALUES('PC')
GO

GO
PRINT N'Update complete.';


GO
