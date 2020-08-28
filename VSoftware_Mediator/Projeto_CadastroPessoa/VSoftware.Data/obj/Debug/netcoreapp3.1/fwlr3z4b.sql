IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Pessoas] (
    [Id] int NOT NULL IDENTITY,
    [Nome] varchar(200) NOT NULL,
    [Documento] varchar(20) NOT NULL,
    [DataNascimento] DateTime NOT NULL,
    [Idade] integer NOT NULL,
    [OpcaoSexual] integer NOT NULL,
    [Profissao] varchar(200) NOT NULL,
    CONSTRAINT [PK_Pessoas] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200821190400_Startup', N'3.1.7');

GO

