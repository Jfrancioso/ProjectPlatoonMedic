--it is common usage to first switch over to the main system database 
USE master
GO

--if the meetups DB already exists, drop it (but only if it already exists) 
DROP DATABASE IF EXISTS PlatoonMedic;

--create a new database named "meetups"
CREATE DATABASE PlatoonMedic;
GO

--switch over to using the meetups database
USE PlatoonMedic
GO

BEGIN TRANSACTION;

-- Create the user table
CREATE TABLE [user]
(
    user_id UNIQUEIDENTIFIER PRIMARY KEY NOT NULL,
    username VARCHAR(50) NOT NULL,
    password VARCHAR(50) NOT NULL,
    role VARCHAR(50) NOT NULL
);

-- Create the company table
CREATE TABLE company
(
    company_id INT PRIMARY KEY NOT NULL,
    company_name VARCHAR(50) NOT NULL,
    company_commander_id UNIQUEIDENTIFIER
);

-- Create the platoon table
CREATE TABLE platoon
(
    platoon_id INT PRIMARY KEY NOT NULL,
    platoon_name VARCHAR(50) NOT NULL,
    platoon_leader_id UNIQUEIDENTIFIER,
    company_id INT FOREIGN KEY REFERENCES company(company_id)
);

-- Create the soldier table
CREATE TABLE soldier
(
	soldier_id UNIQUEIDENTIFIER PRIMARY KEY NOT NULL,
	soldier_name VARCHAR(50) NOT NULL,
	soldier_rank VARCHAR(20) NOT NULL,
	medical_status VARCHAR(50),
	platoon_id INT FOREIGN KEY REFERENCES platoon(platoon_id),
	user_id UNIQUEIDENTIFIER FOREIGN KEY REFERENCES [user](user_id)
);


-- Create the medical record table
CREATE TABLE medical_record
(
	medical_record_id UNIQUEIDENTIFIER PRIMARY KEY NOT NULL,
	soldier_id UNIQUEIDENTIFIER FOREIGN KEY REFERENCES soldier(soldier_id),
	medical_condition VARCHAR(100),
	treatment VARCHAR(100),
	prescription VARCHAR(100),
	medical_status_updated_by UNIQUEIDENTIFIER FOREIGN KEY REFERENCES [user](user_id),
	medical_status_updated_on DATETIME
);



COMMIT;