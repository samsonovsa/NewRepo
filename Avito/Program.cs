using Avito.Context;
using Avito.Models;

var connectionString = "Host=localhost;Port=5432;Database=avito;Username=root;Password=root;";
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;

using (var dbContext = new AvitoDbContext(connectionString))
{
    ShowUsers(dbContext);
    ShowProucts(dbContext);
    ShowSales(dbContext);
    ShowReviews(dbContext);
    SetUser(dbContext);
    ShowUsers(dbContext);
}

static void ShowUsers(AvitoDbContext dbContext)
{
    var users = dbContext.Users.ToList();
    Console.WriteLine("Пользователи:");
    foreach (var user in users)
    {
        Console.WriteLine(
            $"Имя: {user.Username}, " +
            $"Email: {user.Email}");
    }
    Console.WriteLine();
}

static void ShowProucts(AvitoDbContext dbContext)
{
    var products = dbContext.Products.ToList();
    Console.WriteLine("Товары:");
    foreach (var product in products)
    {
        Console.WriteLine(
            $"Наименование: {product.Title}, " +
            $"Описание: {product.Description}, " +
            $"Продавец: {product.Seller.Username}");
    }
    Console.WriteLine();
}

static void ShowSales(AvitoDbContext dbContext)
{
    var sales = dbContext.Sales.ToList();
    Console.WriteLine("Продажи:");
    foreach (var sale in sales)
    {
        Console.WriteLine(
            $"Товар: {sale.Product.Title}, " +
            $"Описание: {sale.Product.Description}, " +
            $"Продавец: {sale.Seller.Username}, " +
            $"Покупатель: {sale.Buyer.Username}, " +
            $"Цена: {sale.Price}, " +
            $"Дата продажи: {sale.SaleDate}");
    }
    Console.WriteLine();
}

static void ShowReviews(AvitoDbContext dbContext)
{
    var reviews = dbContext.Reviews.ToList();
    Console.WriteLine("Отзывы:");
    foreach (var review in reviews)
    {
        Console.WriteLine(
            $"Продукт: {review.Product.Title}, " +
            $"Рейтинг: {review.Rating}, " +
            $"Комментарий: {review.Comment}");
    }
    Console.WriteLine();
}

void SetUser(AvitoDbContext dbContext)
{
    Console.WriteLine("Введите нового пользователя:");
    Console.Write("Введите имя нового пользователя: ");
    string name = Console.ReadLine() ?? "Default Name";
    Console.Write("Введите email нового пользователя: ");
    string email = Console.ReadLine() ?? "default@mail.ru";
    Console.Write("Введите пароль для нового пользователя: ");
    string password = Console.ReadLine() ?? "DefaultPassword";

    dbContext.Users.Add(new User
    {
        Username = name,
        Email = email,
        Password = password
    });

    dbContext.SaveChanges();
}
