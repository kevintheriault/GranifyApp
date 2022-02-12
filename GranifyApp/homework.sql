-- These will be able to store our pet data the Model in C# would just have to
-- be changed to allow for ids

CREATE TABLE Cat(
    id int IDENTITY PRIMARY KEY,
    name varchar(50),
    age int,
    favorite_food varchar(255)
);

CREATE TABLE Dog(
    id int IDENTITY PRIMARY KEY,
    name varchar(50),
    age int,
    favorite_food varchar(255)
)

INSERT INTO cat(name, age, favorite_food)
VALUES("Lily", 2, "Tuna");

INSERT INTO dog(name, age, favorite_food)
VALUES("Louis", 2, "Beef");