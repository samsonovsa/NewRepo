using Avito.Context;

var connectionString = "Host=localhost;Port=5432;Database=avito;Username=root;Password=root;";
Console.OutputEncoding = System.Text.Encoding.UTF8;

using (var dbContext = new AvitoDbContext(connectionString))
{
    ShowUsers(dbContext);
    ShowProucts(dbContext);
    ShowSales(dbContext);
    ShowReviews(dbContext);
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
