


using ConsoleApp1.Data;

var dbContext = new ProductContext();

dbContext.Database.EnsureCreated();