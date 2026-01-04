using ConsoleApp1.Infrastructure.Data;

var dbContext = new ProductContext();

dbContext.Database.EnsureCreated();