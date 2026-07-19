SELECT
    ProductID,
    ProductName,
    Category,
    Price,
    ROW_NUMBER() OVER
    (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS RowNumber,
    RANK() OVER
    (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS RankNumber,

    DENSE_RANK() OVER
    (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS DenseRank
FROM Products;

SELECT *
FROM
(
    SELECT
        ProductID,
        ProductName,
        Category,
        Price,

        ROW_NUMBER() OVER
        (
            PARTITION BY Category
            ORDER BY Price DESC
        ) AS RowNum

    FROM Products
) AS T

WHERE RowNum <= 3;