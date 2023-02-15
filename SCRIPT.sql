create database Shop
go
use Shop

Create Table Product
(
	ID int PRIMARY KEY IDENTITY(1,1),
	Name nvarchar(100) not null,
)

Create table Category
(
	ID int PRIMARY KEY IDENTITY(1,1),
	Name nvarchar(100) not null
)

Create table CategoriesAndProducts
(
	CategoryID int foreign key references Category(ID),
	ProductID int foreign key references Product(ID),
)

INSERT INTO Product VALUES
('Молоко 1л'),
('Печенье 200гр'),
('Молочные вафли 300гр'),
('Туалетная бумага 6 рулонов'),
('Куриный фарш 1кг'),
('Говяжий фарш 2кг')

INSERT INTO Category VALUES
('Молоко и молочные продукты'),
('Мясо и мясопродукты'),
('Хлебные продукты')

INSERT INTO CategoriesAndProducts VALUES
(1,1),
(3,2),
(3,3),
(1,3),
(2,5),
(2,6)

-- SQL запрос для выбора всех пар «Имя продукта – Имя категории».
-- Если у продукта нет категорий, то его имя все равно должно выводиться.
SELECT P.Name as 'Имя продукта', C.Name as 'Имя категории'
FROM Product as P
INNER JOIN CategoriesAndProducts as CAP
			ON CAP.ProductID = p.ID
INNER JOIN Category as C 
			ON C.ID = CAP.CategoryID

UNION

SELECT P.Name, 'Отсутствует'
FROM Product as P
WHERE NOT EXISTS(
	SELECT NULL
	FROM CategoriesAndProducts as CAP
	WHERE CAP.ProductID = P.ID)

