CREATE TABLE Registration (
    tribunal_id INT PRIMARY KEY IDENTITY (1, 1),
    tribunal_ref VARCHAR (50) NOT NULL,
    last_name VARCHAR (50) NOT NULL,
    first_name VARCHAR (50) NOT NULL,   
);
