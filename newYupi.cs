using System;

abstract class Theater
{
    protected int numberOfSeats;
    protected int numberOfRows;
    protected bool hasOrchestraPit;
    protected double stageLength;
    protected double stageWidth;

    public Theater(int seats, int rows, bool orchestraPit, double length, double width)
    {
        numberOfSeats = seats;
        numberOfRows = rows;
        hasOrchestraPit = orchestraPit;
        stageLength = length;
        stageWidth = width;
    }

    public abstract string GetInfo();
}

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
        return $"Кукольный театр: {numberOfSeats} мест, {numberOfRows} рядов, оркестровая яма: {(hasOrchestraPit ? "есть" : "нет")}, размер сцены: {stageLength}x{stageWidth} м, кукловод: {puppeteer}.";
    }
}

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
        return $"Цирковая арена: {numberOfSeats} мест, {numberOfRows} рядов, оркестровая яма: {(hasOrchestraPit ? "есть" : "нет")}, размер сцены: {stageLength}x{stageWidth} м, артист: {circusArtist}.";
    }
}

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
        return $"Кинотеатр: {numberOfSeats} мест, {numberOfRows} рядов, оркестровая яма: {(hasOrchestraPit ? "есть" : "нет")}, размер сцены: {stageLength}x{stageWidth} м, оператор: {projectionist}.";
    }
}

class Program
{
    static void Main()
    {
        // Запрос данных у пользователя для каждого типа театра
        Console.WriteLine("Введите данные для кукольного театра:");
        Console.Write("Количество мест: ");
        int puppetSeats = int.Parse(Console.ReadLine());
        Console.Write("Количество рядов: ");
        int puppetRows = int.Parse(Console.ReadLine());
        Console.Write("Наличие оркестровой ямы (true/false): ");
        bool puppetOrchestraPit = bool.Parse(Console.ReadLine());
        Console.Write("Размер сцены (длина): ");
        double puppetLength = double.Parse(Console.ReadLine());
        Console.Write("Размер сцены (ширина): ");
        double puppetWidth = double.Parse(Console.ReadLine());
        Console.Write("Кукловод: ");
        string puppeteer = Console.ReadLine();

        PuppetTheater puppetTheater = new PuppetTheater(puppetSeats, puppetRows, puppetOrchestraPit, puppetLength, puppetWidth, puppeteer);
        Console.WriteLine(puppetTheater.GetInfo());

        Console.WriteLine("\nВведите данные для цирковой арены:");
        Console.Write("Количество мест: ");
        int circusSeats = int.Parse(Console.ReadLine());
        Console.Write("Количество рядов: ");
        int circusRows = int.Parse(Console.ReadLine());
        Console.Write("Наличие оркестровой ямы (true/false): ");
        bool circusOrchestraPit = bool.Parse(Console.ReadLine());
        Console.Write("Размер сцены (длина): ");
        double circusLength = double.Parse(Console.ReadLine());
        Console.Write("Размер сцены (ширина): ");
        double circusWidth = double.Parse(Console.ReadLine());
        Console.Write("Артист: ");
        string circusArtist = Console.ReadLine();

        CircusArena circusArena = new CircusArena(circusSeats, circusRows, circusOrchestraPit, circusLength, circusWidth, circusArtist);
        Console.WriteLine(circusArena.GetInfo());

        Console.WriteLine("\nВведите данные для кинотеатра:");
        Console.Write("Количество мест: ");
        int cinemaSeats = int.Parse(Console.ReadLine());
        Console.Write("Количество рядов: ");
        int cinemaRows = int.Parse(Console.ReadLine());
        Console.Write("Наличие оркестровой ямы (true/false): ");
        bool cinemaOrchestraPit = bool.Parse(Console.ReadLine());
        Console.Write("Размер сцены (длина): ");
        double cinemaLength = double.Parse(Console.ReadLine());
        Console.Write("Размер сцены (ширина): ");
        double cinemaWidth = double.Parse(Console.ReadLine());
        Console.Write("Оператор: ");
        string projectionist = Console.ReadLine();

        CinemaTheater cinemaTheater = new CinemaTheater(cinemaSeats, cinemaRows, cinemaOrchestraPit, cinemaLength, cinemaWidth, projectionist);
        Console.WriteLine(cinemaTheater.GetInfo());
    }
}
