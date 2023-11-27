
class Car
{
    private const string CompanyName = "Mercedec_Benz";

    public string Name { get; set; }
    public string Color { get; set; }
    public double Price { get; set; }

    // База
    public Car()
    {
        Name = "Unknown";
        Color = "Unknown";
        Price = 0.0;
    }

    //параметри
    public Car(string name, string color, double price)
    {
        Name = name;
        Color = color;
        Price = price;
    }

    public void Input()
    {
        Console.Write("Введіть назву авто: ");
        Name = Console.ReadLine();

        Console.Write("Введіть колір авто: ");
        Color = Console.ReadLine();

        Console.Write("Введіть ціну авто: ");
        if (double.TryParse(Console.ReadLine(), out double price))
        {
            Price = price;
        }
        else
        {
            Console.WriteLine("Некоректний ввід для ціни. Встановлено ціну за замовчуванням (0).");
        }
    }

    // Метод для виведення даних про машину на консоль
    public void Print()
    {
        Console.WriteLine($"Назва: {Name}");
        Console.WriteLine($"Колір: {Color}");
        Console.WriteLine($"Ціна: {Price:C}");
        Console.WriteLine($"Компанія: {CompanyName}");
    }

    // Метод для зміни ціни далі викорастаю для 10%
    public void ChangePrice(double percent)
    {
        Price *= (1 - percent / 100);
    }

    // Метод для зміни кольору авто
    public void PaintCar(string newColor)
    {
        if (Color.ToLower() == "white")
        {
            Color = newColor;
        }
    }

    // Дані про авто
    public string PrintInfo()
    {
        return $"Назва: {Name}, Колір: {Color}, Ціна: {Price:C}, Компанія: {CompanyName}";
    }
}

class Program
{
    static void Main()
    {
        // Створення ще класів Car
        Car car1 = new Car();
        Car car2 = new Car("Honda", "red", 145000);
        Car car3 = new Car();

        // Введення даних про автомобілі
        car1.Input();
        car3.Input();

        // Зменшення ціни на 10%
        car1.ChangePrice(10);
        car2.ChangePrice(10);
        car3.ChangePrice(10);

        // Виведення даних про автомобілі
        Console.WriteLine("\nДані після зменшення ціни на 10%:");
        car1.Print();
        car2.Print();
        car3.Print();

        // Введення нового кольору і пофарбування авто з кольором white
        Console.WriteLine("\nВведіть новий колір для авто з кольором white:");
        string newColor = Console.ReadLine();
        car1.PaintCar(newColor);

        // Виведення інформації про автомобілі за допомогою методу PrintInfo
        Console.WriteLine("\nІнформація про автомобілі:");
        Console.WriteLine(car1.PrintInfo());
        Console.WriteLine(car2.PrintInfo());
        Console.WriteLine(car3.PrintInfo());
    }
}
