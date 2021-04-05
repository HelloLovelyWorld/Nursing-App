CREATE TABLE [dbo].[FeedingLog] (
    [Baby ID]      INT           IDENTITY (1, 1) NOT NULL,
    [Amount Fed]    INT            NOT NULL,
    [Time Fed] DATETIME      NULL,
    [Milk ID]      INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Baby ID] ASC),
    FOREIGN KEY ([Milk ID]) REFERENCES [dbo].[MilkStorage] 
)
