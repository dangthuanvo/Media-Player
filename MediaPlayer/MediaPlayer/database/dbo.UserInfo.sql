CREATE TABLE [dbo].[UserInfo] (
    [FirstName] VARCHAR (50) NOT NULL,
    [LastName]  VARCHAR (50) NOT NULL,
    [UserName]  VARCHAR (50) NOT NULL,
    [Password]  VARCHAR (10) NOT NULL,
    CONSTRAINT [PK_UserInfo] PRIMARY KEY CLUSTERED ([UserName])
);

