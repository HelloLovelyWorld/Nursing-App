CREATE TABLE [dbo].[Diapers] (
    [Mom ID]      INT           IDENTITY (1, 1) NOT NULL,
    [Baby ID]      INT            NOT NULL,
    [Number of Urine Diapers] INT       NULL,
    [Number of Soiled Diapers] INT      NULL,
    [Number of Mixed Diapers] INT       NULL,
    [Date of Diaper Chang] DATETIME      NOT NULL,
)
