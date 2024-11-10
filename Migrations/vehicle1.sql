IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbl_vehicle' AND schema_id = SCHEMA_ID('dbo'))
BEGIN
    CREATE TABLE [dbo].[tbl_vehicle]
    (
        [id]               INT  IDENTITY(1,1) PRIMARY KEY NOT NULL,
        [License_plate]    NCHAR (7)  UNIQUE              NOT NULL,
        [Brand]            VARCHAR (25)  NOT NULL,
        [Model]            VARCHAR (55)  NOT NULL,
        [Model_year]       DATE          NOT NULL,
        [Chassis_number]   NCHAR (17)    NOT NULL,
        [Renavam]          NCHAR (11)    NOT NULL,
        [Color]            VARCHAR (25)  NOT NULL,
        [Fuel_type]        VARCHAR (15)  NOT NULL,
        [Mileage]          INT           NOT NULL,
        [OBS]              VARCHAR (255) NULL,
	    [Direction]        VARCHAR (15)  NOT NULL,
        [Air_conditioning] BIT           DEFAULT 0 NOT NULL,
        [Electric_windows] BIT           DEFAULT 0 NOT NULL,
        [Electric_locks]   BIT           DEFAULT 0 NOT NULL,
        [Licensed]         BIT           DEFAULT 0 NOT NULL,
    );
END;
