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
('������ 1�'),
('������� 200��'),
('�������� ����� 300��'),
('��������� ������ 6 �������'),
('������� ���� 1��'),
('������� ���� 2��')

INSERT INTO Category VALUES
('������ � �������� ��������'),
('���� � ������������'),
('������� ��������')

INSERT INTO CategoriesAndProducts VALUES
(1,1),
(3,2),
(3,3),
(1,3),
(2,5),
(2,6)

-- SQL ������ ��� ������ ���� ��� ���� �������� � ��� ���������.
-- ���� � �������� ��� ���������, �� ��� ��� ��� ����� ������ ����������.
SELECT P.Name as '��� ��������', C.Name as '��� ���������'
FROM Product as P
INNER JOIN CategoriesAndProducts as CAP
			ON CAP.ProductID = p.ID
INNER JOIN Category as C 
			ON C.ID = CAP.CategoryID

UNION

SELECT P.Name, '�����������'
FROM Product as P
WHERE NOT EXISTS(
	SELECT NULL
	FROM CategoriesAndProducts as CAP
	WHERE CAP.ProductID = P.ID)