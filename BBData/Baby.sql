CREATE TABLE [dbo].[Baby] (
    [Mom ID]      INT           IDENTITY (1, 1) NOT NULL,
    [Last Name]       NVARCHAR (50) NULL,
    [First Name]      NVARCHAR (50) NULL,
    [Date Of Birth] DATETIME      NULL,
    [Baby ID]      INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Baby ID] ASC)
)