using lab5;

class Program
{
    static void Main()
    {
        Product product1 = new Product("Літня футболка", 19.99, "Зручна футболка для літа", "Одяг");
        Product product2 = new Product("Смартфон", 499.99, "Остання версія айфону", "Електроніка");
        Product product3 = new Product("Манга 'Re Zero'", 39.99, "Історія у вигляді картинок", "Книга");

        User user1 = new User("Vitaliy", "etoya");
        User user2 = new User("Anzhela", "15jul");


        user1.AddToPurchaseHistory(product1);
        user1.AddToPurchaseHistory(product3);
        user2.AddToPurchaseHistory(product2);



        Console.WriteLine("Користувач 1:");
        Console.WriteLine($"Логін: {user1.Username}");
        Console.WriteLine("Історія покупок:");
        foreach (Product product in user1.PurchaseHistory)
        {
            Console.WriteLine($"Назва: {product.Name}, Ціна: {product.Price}");
        }

        Console.WriteLine();

        Console.WriteLine("Користувач 2:");
        Console.WriteLine($"Логін: {user2.Username}");
        Console.WriteLine("Історія покупок:");
        foreach (Product product in user2.PurchaseHistory)
        {
            Console.WriteLine($"Назва: {product.Name}, Ціна: {product.Price}");
        }

        Console.ReadLine();
    }
}