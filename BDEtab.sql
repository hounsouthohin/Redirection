CREATE DATABASE BDEtab;
go
USE BDEtab;

CREATE TABLE Etablissement (
    idEtablissement INT IDENTITY(1,1) PRIMARY KEY,
    nomEtab VARCHAR(100)      NOT NULL,                 
    delaiInscription INT      NOT NULL,                         
    contact VARCHAR(50)       NOT NULL,                           
    nomProviseur VARCHAR(100) NOT NULL,    
    prenomProviseur VARCHAR(100)         NOT NULL,                
    Region VARCHAR(50)        NOT NULL,                            
    dateRentre DATE           NOT NULL,                               
    province VARCHAR(50)      NOT NULL,                          
    ville VARCHAR(50)         NOT NULL,                             
    secteur VARCHAR(50)       NOT NULL                           
);


CREATE TABLE Eleve (
    noPv INT IDENTITY(1,1) PRIMARY KEY, 
    idEtablissement INT NOT NULL,
    nom VARCHAR(50) NOT NULL,    
    prenom VARCHAR(50) NOT NULL, 
    courriel VARCHAR(100) UNIQUE NOT NULL, 
    motDePasse VARCHAR(100) UNIQUE NOT NULL,
    date_naissance DATE NOT NULL,
    date_inscription DATE NOT NULL,
	FOREIGN KEY(idEtablissement) REFERENCES Etablissement(idEtablissement)
);

CREATE TABLE Classe (
    idClasse INT IDENTITY(1,1) PRIMARY KEY,        
    nomClasse NVARCHAR(100) NOT NULL,              
    nbEleves INT,                                  
    idEtablissement INT,                           
    FOREIGN KEY (idEtablissement) REFERENCES Etablissement(idEtablissement) ON DELETE CASCADE
);

CREATE TABLE Cour (
    idCour INT IDENTITY(1,1) PRIMARY KEY,          
    nomCour NVARCHAR(100) NOT NULL,                
    nomProf NVARCHAR(100) NOT NULL,                         
    dureeSemaine INT      NOT NULL,                              
    dureeJour INT         NOT NULL,                                 
    idClasse INT          NOT NULL,                                  
    FOREIGN KEY (idClasse) REFERENCES Classe(idClasse) ON DELETE CASCADE
);

CREATE TABLE Notifications (
    idNotifications INT IDENTITY(1,1) PRIMARY KEY, 
    date DATE               NOT NULL,                            
    message NVARCHAR(MAX)   NOT NULL,                
    noPv INT                NOT NULL,
    idEtablissement INT     NOT NULL,
    vue BIT DEFAULT 0       NOT NULL,                             
    FOREIGN KEY (noPv) REFERENCES Eleve(noPv) ON DELETE CASCADE,
    FOREIGN KEY (idEtablissement) REFERENCES Etablissement(idEtablissement) ON DELETE CASCADE
);

CREATE TABLE PhotoEleve (
    noPhoto INT IDENTITY(1,1) PRIMARY KEY,         
    sourcePhoto NVARCHAR(255) NOT NULL,            
    noPv INT                  NOT NULL,                                      
    FOREIGN KEY (noPv) REFERENCES Eleve(noPv) ON DELETE CASCADE
);


