CREATE TABLE Staff(
StaffID numeric(4) NOT NULL,
Surname char(25) NOT NULL,
Forename char(25) NOT NULL,
DOB date NOT NULL,
Email char(35),
PhoneNumber char(12),
CONSTRAINT pk_StaffID PRIMARY KEY(StaffID));

INSERT INTO Staff
VALUES(0001,'Smith','John','13-FEB-1982','johnsmith@gmail.com','0871238736');

INSERT INTO Staff
VALUES(0002,'Doe','Jane','18-OCT-1990','janedoe@hotmail.com','0851838230');

INSERT INTO Staff
VALUES(0003,'Fry','Robert','25-AUG-1979','robfry@hotmail.com','0871639222');

Commit;