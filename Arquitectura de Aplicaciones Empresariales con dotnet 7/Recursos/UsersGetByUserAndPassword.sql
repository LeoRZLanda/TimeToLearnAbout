SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UsersGetByUserAndPassword]
(
    @UserName VARCHAR(50),
    @Password VARCHAR(50)
)
AS
BEGIN

    SELECT UserID, FirstName, LastName, UserName, NULL AS PASSWORD
    FROM Users
    WHERE UserName = @UserName AND Password = @Password

END
GO