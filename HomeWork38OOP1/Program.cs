internal class Program
{
    private static void Main(string[] args)
    {
        Player player = new Player("Иван", 18, 15);

        player.ShowInfo();
    }
}

class Player
{
    public string Name;
    public int Age;
    public int Level;

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