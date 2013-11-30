CREATE TABLE [dbo].[Company] (
    [Id]           INT           NOT NULL,
    [Column_B]     TEXT          NULL,
    [Name]         VARCHAR (100) NOT NULL,
    [Shortcut]     VARCHAR (3)   NOT NULL,
    [ShareNumbers] BIGINT        NULL,
    [SharePrice]   FLOAT (53)    NULL,
    [Date]         DATETIME      NULL,
    [Description]  TEXT          NULL,
    [Column_I]     VARCHAR (25)  NULL,
    [Column_J]     BIGINT        NULL,
    [Column_K]     BIGINT        NULL,
    [Column_L]     TEXT          NULL,
    [Href]         VARCHAR (50)  NULL,
    [PhoneNumber]  VARCHAR (50)  NULL,
    [Email]        VARCHAR (50)  NULL,
    [FullName]     VARCHAR (50)  NULL,
    [HeadAccount]  VARCHAR (50)  NULL,
    [Profile]      VARCHAR (50)  NULL,
    [Address]      VARCHAR (50)  NULL,
    [HrefStatus]   VARCHAR (50)  NULL,
    [VoteNumbers]  BIGINT        NULL,
    [Date2]        DATETIME      NULL,
    [Column_W]     TEXT          NULL,
    [Column_X]     TEXT          NULL,
    [Volumen20]    BIGINT        NULL,
    CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_Company]
    ON [dbo].[Company]([Id] ASC);
GO
