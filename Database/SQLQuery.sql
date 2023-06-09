CREATE TABLE Files (
  FileId INT PRIMARY KEY,
  FileName VARCHAR(255),
  FilePath VARCHAR(255),
  Metadata VARCHAR(255),
  Status VARCHAR(50)
);

CREATE TABLE Directories (
  DirectoryId INT PRIMARY KEY,
  DirectoryName VARCHAR(255),
  ParentDirectoryId INT,
  Status VARCHAR(50)
);

CREATE TABLE FileDirectory (
  FileId INT,
  DirectoryId INT,
  PRIMARY KEY (FileId, DirectoryId),
  FOREIGN KEY (FileId) REFERENCES Files (FileId),
  FOREIGN KEY (DirectoryId) REFERENCES Directories (DirectoryId)
);

CREATE TABLE Committees (
  CommitteeId INT PRIMARY KEY,
  CommitteeName VARCHAR(255)
);
