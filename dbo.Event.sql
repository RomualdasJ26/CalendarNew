﻿CREATE TABLE [dbo].[Event] (
    [Id]   INT          IDENTITY (1, 1) NOT NULL,
    [date] VARCHAR (50) NOT NULL,
    [name] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

