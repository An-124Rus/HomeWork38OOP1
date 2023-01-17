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
    private string Name;
    private int Age;
    private int Level;

    public Player(string name, int age, int level)
    {
        Name = name;
        Age = age;
        Level = level;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Имя игрока: {Name}\nВозраст: {Age}\nУровень: {Level}");
    }
}