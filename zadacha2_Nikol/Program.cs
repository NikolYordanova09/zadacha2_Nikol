using zadacha2_Nikol;

class Program
{
    static void Main()
    {
        Rectangle rectangle1 = new Rectangle();

        Console.WriteLine("Правоъгълник:");
        Console.WriteLine("Площ: " + rectangle1.Area());

        Rectangle rectangle2 = new Rectangle(5, 10);

        Console.WriteLine("Площ на правоъгълник със страни 5 и 10: "
                          + rectangle2.Area());

        Circle circle1 = new Circle();

        Console.WriteLine("\nКръг:");
        Console.WriteLine("Площ: " + circle1.Area());

        Circle circle2 = new Circle(5);

        Console.WriteLine("Площ на кръг с радиус 5: "
                          + circle2.Area());

        try
        {
            Rectangle rectangle3 = new Rectangle(5, 0);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("\nГрешка: " + ex.Message);
        }

        try
        {
            Circle circle3 = new Circle(0);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Грешка: " + ex.Message);
        }
    }
}