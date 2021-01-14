CREATE TABLE [dbo].[Car] (
    [Id]                 INT          NOT NULL PRIMARY KEY IDENTITY,
    [RegistrationNumber] VARCHAR (50) NOT NULL,
    [CarType]            VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

