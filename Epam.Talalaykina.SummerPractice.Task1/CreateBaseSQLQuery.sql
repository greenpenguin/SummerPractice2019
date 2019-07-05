CREATE DATABASE STORE_RATING_SYSTEM3	 
COLLATE Cyrillic_General_100_CI_AS
GO

CREATE TABLE User_List 
(
ID_User int NOT NULL IDENTITY (1,1),
User_Login nvarchar(50) NOT NULL
)

GO

CREATE TABLE Store_List 
(
ID_Store int NOT NULL IDENTITY (1,1),
Store_Name nvarchar(50) NOT NULL
)

GO

CREATE TABLE User_Rating_List
(
ID_User int NOT NULL,
ID_Store int NOT NULL,
Assortment_Rating int NOT NULL,
Price_Level_Rating int NOT NULL,
Service_Rating int NOT NULL
)

GO

CREATE TABLE Registration_List
(
ID_Registration int NOT NULL IDENTITY (1,1),
ID_User int NOT NULL,
User_Login nvarchar(50) NOT NULL,
User_Password nvarchar(50) NOT NULL
)
GO

ALTER TABLE User_List
ADD
PRIMARY KEY(ID_User)
GO

ALTER TABLE Store_List
ADD
PRIMARY KEY(ID_Store)
GO

ALTER TABLE Registration_List
ADD
PRIMARY KEY(ID_Registration)
GO

ALTER TABLE User_Rating_List
ADD
FOREIGN KEY (ID_User) REFERENCES User_List (ID_User)
GO

ALTER TABLE User_Rating_List
ADD
FOREIGN KEY (ID_Store) REFERENCES Store_List (ID_Store)
GO

ALTER TABLE Registration_List
ADD
FOREIGN KEY (ID_User) REFERENCES User_List (ID_User)
GO

insert into User_List values ('Dora_the_Explorer')
go

insert into User_List values ('BFGT')
go

insert into User_List values ('Penguin')
go

insert into Store_List values ('The iStore')
go

insert into Store_List values ('Летуаль')
go

insert into Store_List values ('ASOS')
go

insert into User_Rating_List values (1, 2, 5, 5, 5)
go

insert into User_Rating_List values (2, 1, 5, 5, 5)
go

insert into User_Rating_List values (2, 3, 5, 5, 5)
go

insert into User_Rating_List values (3, 2, 3, 4, 5)
go

insert into User_Rating_List values (1, 3, 2, 2, 5)
go

insert into User_Rating_List values (1, 1, 5, 4, 5)
go

insert into User_Rating_List values (2, 3, 5, 4, 5)
go

select * from User_List
go

select * from Store_List
go

select * from User_Rating_List
go

select * from Registration_List
go

--- Реализация CRUD
--- INSERT
CREATE PROCEDURE AddUser
@Login nvarchar(50)
AS
INSERT INTO	User_List VALUES (@Login)
GO

EXEC AddUser 'Test'
GO

CREATE PROCEDURE AddStore
@Store_Name nvarchar(50)
AS
INSERT INTO	Store_List VALUES (@Store_Name)
GO

EXEC AddStore 'Test'
GO

CREATE PROCEDURE AddStoreRating
@ID_User int, 
@ID_Store int, 
@Assortment_Rating int, 
@Price_Level_Rating int, 
@Service_Rating int
AS
INSERT INTO	User_Rating_List VALUES (@ID_User, @ID_Store, @Assortment_Rating, @Price_Level_Rating, @Service_Rating)
GO

EXEC AddStoreRating 4, 4, 1, 1, 1
GO

CREATE PROCEDURE AddRegistrationRecord
@ID_User int,
@User_Login nvarchar(50),
@User_Password nvarchar(50)
AS
INSERT INTO	Registration_List VALUES (@ID_User, @User_Login, @User_Password)
GO

EXEC AddRegistrationRecord 1, 'lol', 'qwerty'
GO
--- SELECT
CREATE PROCEDURE SelectUserByID
@ID_User int
AS
SELECT * FROM User_List WHERE (ID_User = @ID_User)
GO

EXEC SelectUserByID 4
GO

CREATE PROCEDURE SelectStoreByID
@ID_Store int
AS
SELECT * FROM Store_List WHERE (ID_Store = @ID_Store)
GO

EXEC SelectStoreByID 3
GO

CREATE PROCEDURE SelectStoreByName
@Store_Name nvarchar(50)
AS
SELECT * FROM Store_List WHERE (Store_Name = @Store_Name)
GO

EXEC SelectStoreByName 'ASOS'
GO

CREATE PROCEDURE SelectStoreRating
@ID_User int, 
@ID_Store int
AS
SELECT * FROM User_Rating_List WHERE (ID_User = @ID_User AND ID_Store = @ID_Store)
GO

EXEC SelectStoreRating 4, 4
GO

CREATE PROCEDURE SelectStoreByNameInRating
@Store_Name nvarchar(50)
AS
DECLARE @ID_Store AS INT = (SELECT ID_Store FROM Store_List WHERE (Store_Name = @Store_Name))
SELECT * FROM User_Rating_List WHERE (ID_Store = @ID_Store)
GO

EXEC SelectStoreByNameInRating 'asos'
GO

CREATE PROCEDURE SelectRegistrationRecord
@ID_Registration int
AS
SELECT * FROM Registration_List WHERE ID_Registration = @ID_Registration
GO

drop procedure SelectRegistrationRecord
go

EXEC SelectRegistrationRecord 1
GO

--- UPDATE
CREATE PROCEDURE UpdateUserByID
@ID_User int,
@Login nvarchar(50)
AS
UPDATE User_List SET User_Login = @Login WHERE (ID_User = @ID_User)
GO

EXEC UpdateUserByID 4, 'TestUpdate'
GO

CREATE PROCEDURE UpdateStoreByID
@ID_Store int,
@Store_Name nvarchar(50)
AS
UPDATE Store_List SET Store_Name = @Store_Name WHERE (ID_Store = @ID_Store)
GO

EXEC UpdateStoreByID 4, 'TestUpdate'
GO

CREATE PROCEDURE UpdateStoreRating
@ID_User int, 
@ID_Store int,
@Assortment_Rating int, 
@Price_Level_Rating int, 
@Service_Rating int
AS
	UPDATE User_Rating_List 
	SET 
		Assortment_Rating = @Assortment_Rating, 
		Price_Level_Rating = @Price_Level_Rating, 
		Service_Rating = @Service_Rating
	WHERE 
		(ID_User = @ID_User AND ID_Store = @ID_Store)
GO

EXEC UpdateStoreRating 4, 4, 2, 2, 2
GO

CREATE PROCEDURE UpdateRegistrationRecord
@ID_Registration int, 
@User_Login nvarchar(50),
@User_Password nvarchar(50)
AS
	UPDATE Registration_List 
	SET 
		User_Login = @User_Login, 
		User_Password = @User_Password
	WHERE 
		ID_Registration = @ID_Registration
GO

drop procedure UpdateRegistrationRecord 
go
--- DELETE
CREATE PROCEDURE DeleteUserByID
@ID_User int
AS
DELETE FROM	User_Rating_List WHERE (ID_User = @ID_User)
DELETE FROM User_List WHERE (ID_User = @ID_User)
GO

DROP PROCEDURE DeleteUserByID
GO

EXEC DeleteUserByID 4
GO

CREATE PROCEDURE DeleteStoreByID
@ID_Store int
AS
DELETE FROM	User_Rating_List WHERE (ID_Store = @ID_Store)
DELETE FROM Store_List WHERE (ID_Store = @ID_Store)
GO

DROP PROCEDURE DeleteStoreByID
GO

EXEC DeleteStoreByID 4
GO

CREATE PROCEDURE DeleteStoreRating
@ID_User int, 
@ID_Store int
AS
DELETE FROM	User_Rating_List WHERE (ID_User = @ID_User AND ID_Store = @ID_Store)
GO

EXEC DeleteStoreRating 4, 4
GO

CREATE PROCEDURE DeleteRegistrationRecordByID
@ID_Registration int
AS
DECLARE @us_id AS INT = (SELECT ID_User FROM Registration_List WHERE @ID_Registration = ID_Registration)
DELETE FROM Registration_List WHERE (@ID_Registration = ID_Registration)
DELETE FROM	User_Rating_List WHERE (ID_User = @us_id)


DELETE FROM User_List WHERE (ID_User = @us_id)

GO

DROP Procedure DeleteRegistrationRecordByID
go

EXEC DeleteRegistrationRecordByID 3
GO

select * from User_List
go

select * from Store_List
go

select * from User_Rating_List
go

select * from Registration_List
go

create procedure IsIRegistrationRecordByID 
@ID_Registration int, @result int output
as
if (select ID_Registration from Registration_List where @ID_Registration = ID_Registration) is null
set @result = -1
else set @result = @ID_Registration
print @result
return @result
go

exec IsIRegistrationRecordByID 3, 0
go

select * from Registration_List
go

exec AddRegistrationRecord 2, 'test', 'test'
go

create procedure IsIRegistrationRecordExistsByLogAndPass 
@User_Login nvarchar(50),
@User_Password nvarchar(50),
@result int output
as
if (select ID_Registration from Registration_List 
	where @User_Login = User_Login and @User_Password = User_Password) is null
set @result = -1
else 
declare @outputID as int = (select ID_Registration from Registration_List 
	where @User_Login = User_Login and @User_Password = User_Password) 
set @result = @outputID
print @result
return @result
go

exec IsIRegistrationRecordExistsByLogAndPass 'testt', 'test', 0
go

create procedure IsIRegistrationRecordExistsByLog 
@User_Login nvarchar(50),
@result int output
as
if (select ID_Registration from Registration_List 
	where @User_Login = User_Login) is null
set @result = -1
else 
declare @outputID as int = (select ID_User from Registration_List 
	where @User_Login = User_Login) 
set @result = @outputID
print @result
return @result
go

drop procedure IsIRegistrationRecordExistsByLog
go

create procedure IsUserExistsByUsername 
@Username nvarchar(50),
@result int output
as
if (select ID_User from User_List 
	where @Username = User_Login) is null
set @result = -1
else 
declare @outputID as int = (select ID_User from User_List 
	where @Username = User_Login) 
set @result = @outputID
print @result
return @result
go

create procedure IsRatingExistsByIDAndName 
@ID_User int,
@Store_Name nvarchar(50),
@result int output
as
declare @ID_Store as int = (select ID_Store from Store_List 
	where @Store_Name = Store_Name)
if (select ID_User from User_Rating_List 
	where @ID_User = ID_User and @ID_Store = ID_Store) is null
set @result = -1
else 
declare @outputID as int = (select ID_Store from User_Rating_List 
	where @ID_User = ID_User and @ID_Store = ID_Store) 
set @result = @outputID
print @result
return @result
go

create procedure IsRatingExistsByID 
@ID_User int,
@ID_Store int,
@result int output
as
if (select top 1 ID_User from User_Rating_List 
	where @ID_User = ID_User and @ID_Store = ID_Store) is null
set @result = -1
else 
declare @outputID as int = (select top 1 ID_User from User_Rating_List 
	where @ID_User = ID_User and @ID_Store = ID_Store) 
set @result = @outputID
print @result
return @result
go

exec IsRatingExistsByID 2, 1, 0
go

drop procedure IsRatingExistsByID 

exec IsRatingExistsByID 2, 1, 0
go

exec IsRatingExistsByIDAndName 2, 'asos', 0
go

create procedure IsRatingExistsByStoreID 
@ID_Store int,
@result int output
as
if (select top 1 ID_Store from User_Rating_List 
	where @ID_Store = ID_Store) is null
set @result = -1
else 
declare @outputID as int = (select top 1 ID_Store from Store_List 
	where @ID_Store = ID_Store)
set @result = @outputID
print @result
return @result
go

drop procedure IsRatingExistsByStoreID 

exec IsRatingExistsByStoreID 3, 0
go

create procedure IsStoreExistsByStoreName 
@Store_Name nvarchar(50),
@result int output
as
if (select ID_Store from Store_List 
	where @Store_Name = Store_Name) is null
set @result = -1
else 
declare @outputID as int = (select ID_Store from Store_List 
	where @Store_Name = Store_Name) 
set @result = @outputID
print @result
return @result
go

exec IsStoreExistsByStoreName 'asos', 0
go

CREATE PROCEDURE SelectUserIDByUsername
@Username nvarchar(50)
AS
SELECT ID_User FROM User_List WHERE (User_Login = @Username)
GO

drop PROCEDURE SelectUserIDByUsername
go

exec SelectUserIDByUsername 'Penguin'
go

create procedure GetSomeRatingByStoreID
@ID_Store int
as
select Assortment_Rating, 
Price_Level_Rating, 
Service_Rating from User_Rating_List
where (ID_Store = @ID_Store)
go

drop procedure GetSomeRatingByStoreID
exec GetSomeRatingByStoreID 3