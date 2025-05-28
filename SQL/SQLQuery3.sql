USE PetTakip;
GO

CREATE TABLE Treatment
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    PetId INT NOT NULL,
    TreatmentType NVARCHAR(100),
    TreatmentName NVARCHAR(200) NOT NULL,
    TreatmentDate DATETIME NOT NULL,
    Veterinarian NVARCHAR(100),
    Cost DECIMAL(10, 2),
    Diagnosis NVARCHAR(MAX),
    Medications NVARCHAR(300),
    HasFollowUp BIT,
    FollowUpDate DATETIME NULL,

    FOREIGN KEY (PetId) REFERENCES Pet(Id)
);