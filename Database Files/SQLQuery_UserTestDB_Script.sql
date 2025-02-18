
-------------------------------------- Create Database -------------------------------------------
CREATE DATABASE UserTestDB
--================================================================================================

-------------------------------------- Use Database ----------------------------------------------
USE UserTestDB 
--================================================================================================

-------------------------------------- Create User Table -----------------------------------------
CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,  
    Username NVARCHAR(200) NOT NULL,
    PasswordHash NVARCHAR(200) NOT NULL,
    Roles NVARCHAR(50)
);
--================================================================================================

-------------------------------------- Create stored procedure get all user -----------------------
CREATE PROC Get_All_Users
AS
SELECT UserID AS 'UserID',
	   Username AS 'Username',
	   PasswordHash AS 'Password',
	   Roles AS 'Role'
	   FROM Users
--================================================================================================

-------------------------------------- Create stored procedure get employee users -----------------
CREATE PROC Get_Employee_Users
AS
SELECT UserID AS 'UserID',
	   Username AS 'Username',
	   PasswordHash AS 'Password',
	   Roles AS 'Role'
	   FROM Users
	   WHERE Roles = 'Employee'
--================================================================================================

-------------------------------------- Create stored procedure for add user ----------------------
CREATE PROC Add_User
@Username NVARCHAR(200),
@PasswordHash NVARCHAR(200),
@Roles NVARCHAR(50)
AS
INSERT INTO Users (Username, PasswordHash, Roles)
VALUES (@Username, @PasswordHash, @Roles)
--================================================================================================

-------------------------------------- Create stored procedure for update user -------------------
CREATE PROC Update_User
@UserID INT,
@Username NVARCHAR(200),
@PasswordHash NVARCHAR(200),
@Roles NVARCHAR(50)
AS
UPDATE Users SET Username = @Username,
				 PasswordHash = @PasswordHash,
				 Roles = @Roles
				 WHERE UserID = @UserID
--================================================================================================

-------------------------------------- Create stored procedure for delete user -------------------
CREATE PROC Delete_User
@UserID INT
AS
DELETE FROM Users WHERE UserID = @UserID
--================================================================================================

-------------------------------------- Create stored procedure for filter ------------------------
CREATE PROC Filter_Users
@Username NVARCHAR(200),
@Roles NVARCHAR(50)
AS
SELECT UserID AS 'UserID',
	   Username AS 'Username',
	   PasswordHash AS 'Password',
	   Roles AS 'Role'
	   FROM Users
	   WHERE (Username LIKE '%' + @Username + '%' OR @Username IS NULL)
			 AND (Roles = @Roles OR @Roles = '')
--================================================================================================
