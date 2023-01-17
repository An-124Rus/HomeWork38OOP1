internal class Program
{
    private static void Main(string[] args)
    {
        string name = "Владимир";
        int age = 18;
        int level = 15;

        Player player = new Player(name, age, level);

        player.ShowInfo();
    }
}

class Player
{
    private string _name;
    private int _age;
    private int _level;

    public Player(string name, int age, int level)
    {
        _name = name;
        _age = age;
        _level = level;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Имя игрока: {_name}\nВозраст: {_age}\nУровень: {_level}");
    }
}