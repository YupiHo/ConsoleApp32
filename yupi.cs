using System;

// Абстрактный класс "Театр"
abstract class Theater
{
    // Поля
    protected int numberOfSeats;
    protected int numberOfRows;
    protected bool hasOrchestraPit;
    protected double stageLength;
    protected double stageWidth;

    // Конструктор
    public Theater(int seats, int rows, bool orchestraPit, double length, double width)
    {
        numberOfSeats = seats;
        numberOfRows = rows;
        hasOrchestraPit = orchestraPit;
        stageLength = length;
        stageWidth = width;
    }

    // Абстрактный метод для получения информации о театре
    public abstract string GetInfo();
}

// Производный класс "Кукольный театр"
class PuppetTheater : Theater
{
    private string puppeteer;

    public PuppetTheater(int seats, int rows, bool orchestraPit, double length, double width, string puppeteer)
        : base(seats, rows, orchestraPit, length, width)
    {
        this.puppeteer = puppeteer;
    }

    public override string GetInfo()
    {
        return $"Кукольный театр: {numberOfSeats} мест, {numberOfRows} рядов, оркестровая яма: {(hasOrchestraPit ? "есть" : "нет")}, размер сцены: {stageLength}x{stageWidth} м.";
    }
}

// Производный класс "Цирковая арена"
class CircusArena : Theater
{
    private string circusArtist;

    public CircusArena(int seats, int rows, bool orchestraPit, double length, double width, string artist)
        : base(seats, rows, orchestraPit, length, width)
    {
        circusArtist = artist;
    }

    public override string GetInfo()
    {
        return $"Цирковая арена: {numberOfSeats} мест, {numberOfRows} рядов, оркестровая яма: {(hasOrchestraPit ? "есть" : "нет")}, размер сцены: {stageLength}x{stageWidth} м.";
    }
}

// Производный класс "Кинотеатр"
class CinemaTheater : Theater
{
    private string projectionist;

    public CinemaTheater(int seats, int rows, bool orchestraPit, double length, double width, string projectionist)
        : base(seats, rows, orchestraPit, length, width)
    {
        this.projectionist = projectionist;
    }

    public override string GetInfo()
    {
        return $"Кинотеатр: {numberOfSeats} мест, {numberOfRows} рядов, оркестровая яма: {(hasOrchestraPit ? "есть" : "нет")}, размер сцены: {stageLength}x{stageWidth} м.";
    }
}

class Program
{
    static void Main()
    {
        // Пример использования
        PuppetTheater puppetTheater = new PuppetTheater(100, 5, false, 10.5, 8.2, "Мастер кукол");
        Console.WriteLine(puppetTheater.GetInfo());

        CircusArena circusArena = new CircusArena(500, 10, true, 20.0, 15.0, "Акробат");
        Console.WriteLine(circusArena.GetInfo());

        CinemaTheater cinemaTheater = new CinemaTheater(200, 8, false, 18.0, 12.0, "Оператор");
        Console.WriteLine(cinemaTheater.GetInfo());
    }
}
