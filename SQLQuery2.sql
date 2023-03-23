-- Insert data into the user table
INSERT INTO [user] (user_id, username, password, role)
VALUES (NEWID(), 'Joey Francis', 'password123', 'medic');

-- Insert data into the company table
INSERT INTO company (company_id, company_name)
VALUES (1, 'Delta Company');

-- Insert data into the platoon table
INSERT INTO platoon (platoon_id, platoon_name, company_id)
VALUES (1, 'First Platoon', 1);

-- Insert data into the soldier table
DECLARE @UserId UNIQUEIDENTIFIER;
SELECT @UserId = user_id FROM [user] WHERE username = 'Joey_Francis';

INSERT INTO soldier (soldier_id, soldier_name, soldier_rank, platoon_id, user_id)
VALUES (NEWID(), 'Joey Francis', 'Specialist', 1, @UserId);

-- Insert data into the medical_record table
DECLARE @SoldierId UNIQUEIDENTIFIER;
SELECT @SoldierId = soldier_id FROM soldier WHERE soldier_name = 'Joey Francis';

INSERT INTO medical_record (medical_record_id, soldier_id, medical_condition, treatment, prescription, medical_status_updated_by, medical_status_updated_on)
VALUES (NEWID(), @SoldierId, 'Sprained ankle', 'Rest and ice', 'Ibuprofen', @UserId, GETDATE());
