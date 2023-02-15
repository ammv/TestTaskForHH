# TestTaskForHH
Тестовое задание для вакансии MindBox C# developer junior / middle (.net, full-stack / back-end)

## Shapes
Библиотека для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам

## TestShapes
Модульные тесты для проверки библиотеки Shapes

## SCRIPT.sql
Скрипт с тестовой БД для SQL запроса для выбора всех пар «Имя продукта – Имя категории»

### Сам запрос без создания БД
~~~~sql
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
ORDER BY C.Name
~~~~
