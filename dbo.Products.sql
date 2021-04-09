CREATE TABLE [dbo].[Products] (
    [ID]     INT           IDENTITY (1, 1) NOT NULL,
    [Code]   VARCHAR (MAX) NULL,
    [Name]   VARCHAR (MAX) NULL,
    [Amount] INT           NULL,
    [Price]  INT    NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

