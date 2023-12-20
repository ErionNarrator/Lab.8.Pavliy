
public class Cod
{
    public static void Main(string[] args)
    {
        Console.Write("Введите первое целое число: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите второе целое число: ");
        int y = Convert.ToInt32(Console.ReadLine());

        Doom numberX = new Doom(x);
        Doom numberY = new Doom(y);

        int result = (x > y) ? numberX.Cube() : numberY.Cube();

        Console.WriteLine("Куб большего числа: " + result);
    }
}


public class Doom
{
    private int value;

    public int Value
    {
        get { return value; }
        set { this.value = value; }
    }

    public Doom(int value)
    {
        this.value = value;
    }

    public int Cube()
    {
        return value * value * value;
    }
}

