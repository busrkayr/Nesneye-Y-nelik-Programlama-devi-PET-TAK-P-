USE PetTakip;
GO

CREATE TABLE Vaccination (
    Id INT PRIMARY KEY IDENTITY(1,1),
    PetId INT NOT NULL,                              
    Name NVARCHAR(100) NOT NULL,                     
    Date DATE NOT NULL,                              
    IsCompleted BIT NOT NULL DEFAULT 1,              
    VeterinarianName NVARCHAR(100) NULL,
    NextVaccinationDate DATE NULL,                   
    VaccineBrand NVARCHAR(100) NULL,                 
    BatchNumber NVARCHAR(100) NULL                  
);