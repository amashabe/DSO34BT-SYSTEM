/* ------------------ Creating Database and Users ----------------------- */
-- --create database 
-- CREATE DATABASE DSO34BT;

-- --create user 
--CREATE LOGIN Arafat WITH PASSWORD = '340$Uuxwp7Mcxo7Khy'; 

-- --assign user to database 
--CREATE USER Arafat FOR LOGIN Arafat; 

/* ------------------- Creating Tables ---------------------- */

--drop table Users

---- create User table
--CREATE TABLE Users (
--    ID  int IDENTITY(1,1) PRIMARY KEY,
--    LastName varchar(255) NOT NULL,
--    FirstName varchar(255),
--    Age int,
--	Email varchar(255)
--);

---- check table 
--select * from Users

---- insert a User into table
--Insert into Users 
--values 
--	('Main', 'Java', 27, 'java@gmail.com'),
--	('Arab', 'Kevin', 29, 'kevin@gmail.com')

-- find a user 

--select * from users
--where ID = 1

---- edit a User
--Update Users
--	set LastName = 'I got this'
--Where ID = 1

-- delete a user
