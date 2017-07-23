CREATE TABLE [dbo].[Comment] (
    [Id]        INT          IDENTITY (1, 1) NOT NULL,
    [Content]   TEXT         NOT NULL,
    [Username]  VARCHAR (50) NOT NULL,
    [CreatedAt] TIMESTAMP   NOT NULL,
    [ArticleId] INT          NOT NULL,
    [StatusId]  INT          DEFAULT ((1)) NULL,
    [ParentId]  INT          NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([ArticleId]) REFERENCES [dbo].[Article] ([Id]),
    FOREIGN KEY ([StatusId]) REFERENCES [dbo].[Status] ([Id])
);

