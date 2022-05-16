CREATE TABLE [dbo].[Bill]
(
  [CatId] INT NOT NULL PRIMARY KEY,
  [SellerName] VARCHAR(30),
  [Date] DATETIME,
  [TotalAmount] DECIMAL
)