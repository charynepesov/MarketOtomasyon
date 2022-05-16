CREATE TABLE [dbo].[Product]
(
  [ProdId] INT NOT NULL PRIMARY KEY,
  [ProdName] VARCHAR(30),
  [ProdPrice] DECIMAL,
  [ProdQty] INT,
  [ProdCat] VARCHAR(30)
)