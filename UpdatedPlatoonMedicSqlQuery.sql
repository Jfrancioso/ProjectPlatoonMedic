-- Insert data into the user table
INSERT INTO [user] (user_id, username, password, role)
VALUES (NEWID(), 'JFran', 'yeoj', 'medic');

-- Insert data into the company table
INSERT INTO company (company_id, company_name, company_commander_id)
VALUES (1, 'Delta Company', NEWID());,
(2, 'Alpha Company', NEWID());,
(3, 'Bravo Company', NEWID());,
(4, 'Charlie Company', NEWID());

-- Insert data into the platoon table
INSERT INTO platoon (platoon_id, platoon_name, platoon_leader_id, company_id)
VALUES 
    (13, 'First Platoon', NEWID(), 4),
    (14, 'Second Platoon', NEWID(), 4),
    (15, 'Third Platoon', NEWID(), 4),
    (16, 'Fourth Platoon', NEWID(), 4);


-- Insert data into the soldier table
INSERT INTO soldier (soldier_id, soldier_name, soldier_rank, medical_status, platoon_id, user_id)
VALUES --(NEWID(), 'John Doe', 'E-4', 'Healthy', 1, (SELECT user_id FROM [user] WHERE username = 'JohnDoe'));
(NEWID(), 'Joey Fran', 'E-4', 'Healthy', 1, (SELECT user_id FROM [user] WHERE username = 'JFran'));

INSERT INTO soldier (soldier_id, soldier_name, soldier_rank, medical_status, platoon_id, user_id, medic_user_id)
VALUES (NEWID(), 'John Doe', 'E-4', 'Healthy', 1, (SELECT user_id FROM [user] WHERE username = 'JohnDoe'), );

-- Insert data into the medical_record table
INSERT INTO medical_record (medical_record_id, soldier_id, medical_condition, treatment, prescription, medical_status_updated_by, medical_status_updated_on)
VALUES (NEWID(), (SELECT soldier_id FROM soldier WHERE soldier_name = 'John Doe'), 'Sprained ankle', 'Rest and ice', 'Ibuprofen', (SELECT user_id FROM [user] WHERE username = 'JohnDoe'), GETDATE());



--Select data from the user table
SELECT * FROM [user];

-- Select data from the company table
SELECT * FROM company;

-- Select data from the platoon table
SELECT * FROM platoon;

-- Select data from the soldier table
SELECT * FROM soldier;

-- Select data from the medical_record table
SELECT * FROM medical_record;


SELECT s.soldier_id, u.username, s.soldier_name
FROM soldier s
JOIN [user] u ON s.user_id = u.user_id;

--Select data from the user table
SELECT * FROM [user];

UPDATE soldier
SET medic_user_id = '9DDF78AA-5BC0-4B05-88A1-D7A69D049F75'
WHERE soldier_name = 'John Doe';

USE PlatoonMedic;

DELETE FROM [user];
DELETE FROM company;
DELETE FROM platoon;
DELETE FROM soldier WHERE soldier_id = '0EDD09F4-823A-4730-80AF-38A44FD192AB';
DELETE FROM medical_record;


UPDATE [user]
SET role = 'infantry'
WHERE user_id = 'CC1CDCF7-A44F-42D6-8453-48D4A4008CBD';



SELECT s.soldier_id, u.username, s.soldier_name
FROM soldier s
JOIN [user] u ON s.user_id = u.user_id;



ALTER TABLE soldier
ADD medic_user_id UNIQUEIDENTIFIER FOREIGN KEY REFERENCES [user](user_id);


UPDATE soldier
SET medic_user_id = (SELECT user_id FROM [user] WHERE username = 'JoeyFran')
WHERE medic_user_id IS NULL;




SELECT s.soldier_name, s.medical_status, m.medical_condition, m.treatment, m.prescription, p.platoon_name, u.username AS medic_name
FROM soldier s
JOIN medical_record m ON s.soldier_id = m.soldier_id
JOIN platoon p ON s.platoon_id = p.platoon_id
LEFT JOIN [user] u ON s.medic_user_id = u.user_id
WHERE s.soldier_name = 'John Doe'
