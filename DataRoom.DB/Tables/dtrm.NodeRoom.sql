CREATE TABLE [dtrm].[NodeRoom]
(
	[Id] BIGINT NOT NULL PRIMARY KEY,
    CONSTRAINT [FK_NodeRoom_Node] FOREIGN KEY ([Id]) REFERENCES [dtrm].[Node](Id)
)
