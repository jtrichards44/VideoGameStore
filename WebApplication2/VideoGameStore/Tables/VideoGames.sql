CREATE TABLE [dbo].[VideoGames]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(255) NOT NULL, 
    [ReleasedDate] DATE NOT NULL, 
    [Description] VARCHAR(500) NULL, 
    [Rented] BIT NOT NULL, 
    [UPC] NVARCHAR(8) NOT NULL,
	
    [PlatformId] INT NOT NULL, 
    [RatingId] INT NOT NULL,

    FOREIGN KEY ([PlatformId]) REFERENCES Platforms(Id),
    FOREIGN KEY ([RatingId]) REFERENCES Ratings(Id),
)
