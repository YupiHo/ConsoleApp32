using System;

// Абстрактный класс "Театр"
abstract class Theatre
{
    // Поля
    protected int numberOfSeats;
    protected int numberOfRows;
    protected bool hasOrchestraPit;
    protected double stageLength;
    protected double stageWidth;

    // Конструктор
    public Theatre(int seats, int rows, bool orchestraPit, double length, double width)
    {
        numberOfSeats = seats;
        numberOfRows = rows;
        hasOrchestraPit = orchestraPit;
        stageLength = length;
        stageWidth = width;
    }

    // Метод для получения информации о театре
    public virtual string GetInfo()
    {
        return $"Театр: {numberOfSeats} мест, {numberOfRows} рядов, оркестровая яма: {(hasOrchestraPit ? "есть" : "нет")}, размер сцены: {stageLength}x{stageWidth} м.";
    }
}

// Производный класс "Кукольный театр"
class PuppetTheatre : Theatre
{
    // Поле для кукловода
    private string puppeteer;

    // Конструктор
    public PuppetTheatre(int seats, int rows, bool orchestraPit, double length, double width, string puppeteer) //Ошибка: исправить возможность вывода отрицательных чисел
        : base(seats, rows, orchestraPit, length, width) 
    {
        this.puppeteer = puppeteer;
    }

    // Переопределение метода GetInfo
    public override string GetInfo()
    {
        return base.GetInfo() + $", кукловод: {puppeteer}";
    }
}

// Производный класс "Цирковая арена"
class CircusArena : Theatre
{
    // Поле для артиста цирка
    private string circusArtist;

    // Конструктор
    public CircusArena(int seats, int rows, bool orchestraPit, double length, double width, string artist) //Ошибка: исправить возможность вывода отрицательных чисел
        : base(seats, rows, orchestraPit, length, width)
    {
        circusArtist = artist;
    }

    // Переопределение метода GetInfo
    public override string GetInfo()
    {
        return base.GetInfo() + $", артист цирка: {circusArtist}";
    }
}

// Производный класс "Кинотеатр"
class CinemaTheatre : Theatre
{
    // Поле для киномеханика
    private string cinemaTechnician;

    // Конструктор
    public CinemaTheatre(int seats, int rows, bool orchestraPit, double length, double width, string technician) //Ошибка: исправить возможность вывода отрицательных чисел
        : base(seats, rows, orchestraPit, length, width)
    {
        cinemaTechnician = technician;
    }

    // Переопределение метода GetInfo
    public override string GetInfo()
    {
        return base.GetInfo() + $", киномеханик: {cinemaTechnician}";
    }
}

// Пример использования
class Program
{
    static void Main()
    {
        PuppetTheatre puppetTheatre = new PuppetTheatre(100, 10, false, 15.0, 10.0, "Иван Иванов"); //Рекомендация: сделать ввод данных с помощью консоли
        Console.WriteLine(puppetTheatre.GetInfo());

        CircusArena circusArena = new CircusArena(500, 20, true, 30.0, 20.0, "Алексей Смирнов");
        Console.WriteLine(circusArena.GetInfo());

        CinemaTheatre cinemaTheatre = new CinemaTheatre(300, 15, false, 25.0, 15.0, "Мария Петрова");
        Console.WriteLine(cinemaTheatre.GetInfo());
    }
}
