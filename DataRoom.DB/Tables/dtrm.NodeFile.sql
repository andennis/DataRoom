﻿CREATE TABLE [dtrm].[NodeFile]
(
	[Id] BIGINT NOT NULL PRIMARY KEY, 
    [MimeType] NVARCHAR(50) NULL, 
    [FileStorageId] BIGINT NOT NULL, 
    [FileSize] BIGINT NULL, 
    CONSTRAINT [FK_NodeFile_Node] FOREIGN KEY ([Id]) REFERENCES [dtrm].[Node]([Id])
)
