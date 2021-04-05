CREATE TABLE [dbo].[Sleep] (
    [Mom ID]      INT           IDENTITY (1, 1) NOT NULL,
    [Baby ID]      INT            NOT NULL,
    [Start Sleep Time] DATETIME       NOT NULL,
    [End Sleep Time] DATETIME      NOT NULL,
    [Total Sleep Time In 24 Hours] INT       NOT NULL, 
    CONSTRAINT [PK_Sleep] PRIMARY KEY ([Baby ID]),
)
