SELECT Products.Name AS ProductName, Categories.Name AS CategoryName
FROM Products
LEFT JOIN ProductsCategories
ON Products.Id=ProductsCategories.ProductId
LEFT JOIN Categories
ON Categories.Id=ProductsCategories.CategoryId
ORDER BY Products.Id