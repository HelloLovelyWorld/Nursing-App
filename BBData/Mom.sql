CREATE TABLE [dbo].[Mom] (
    [Mom ID]      INT           IDENTITY (1, 1) NOT NULL,
    [Last Name]       NVARCHAR (50) NULL,
    [First Name]      NVARCHAR (50) NULL,
    [Number Of Babies] DATETIME      NULL,
    [Baby ID]      INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Mom ID] ASC)
)
