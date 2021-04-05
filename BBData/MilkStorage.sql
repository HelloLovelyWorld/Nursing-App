CREATE TABLE [dbo].[MilkStorage] (
    [Mom ID]      INT           IDENTITY (1, 1) NOT NULL,
    [Baby ID]      INT            NOT NULL,
    [Amount Stored] INT            NOT NULL,
    [Date Stored] DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([Mom ID] ASC),
    FOREIGN KEY ([Baby ID]) REFERENCES [dbo].[FeedingLog] 
)
