--CREATE TABLE Agents (
--    Aid INT PRIMARY KEY IDENTITY,
--    Aname NVARCHAR(max),
--    Alname NVARCHAR(max),
--    AgentId NVARCHAR(max),
--    Aaddress NVARCHAR(max),
--    Aphone NVARCHAR(max),
--    Apassword NVARCHAR(max)
--);

CREATE TABLE Property (
    Pid INT PRIMARY KEY IDENTITY,
    Aid INT,
    Pname NVARCHAR(max),
    RoomNumber INT,
    PFloor INT,
    PAddress NVARCHAR(max),
    City NVARCHAR(max),
    Area NVARCHAR(max),
    TypeDeal NVARCHAR(max),
    PriceReq INT,
    Pic NVARCHAR(max),
    FOREIGN KEY (Aid) REFERENCES Agents(Aid)
);