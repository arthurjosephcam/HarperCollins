﻿CREATE TABLE [dbo].[EventLogs]
(
	[EventLogId] INT IDENTITY(1,1) NOT NULL,
	[Host] VARCHAR(255) NOT NULL,
	[Date] DATETIME NOT NULL,
	[Level] VARCHAR(50) NULL,
	[Category] VARCHAR(255) NULL,
	[Thread] VARCHAR(255) NOT NULL,
	[Method] VARCHAR(20) NULL,
	[Principal] VARCHAR(255) NULL,
	[UserAgent] VARCHAR(255) NULL,
	[UserAddress] VARCHAR(255) NULL,
	[Uri] VARCHAR(1000) NULL,
	[Duration] INT NULL,
	[ResponseCode] INT NULL,
	[Message] VARCHAR(MAX) NULL,
	[Exception] VARCHAR(MAX) NULL,
    CONSTRAINT [PK_EventLogs] PRIMARY KEY CLUSTERED ([EventLogId] ASC)
)