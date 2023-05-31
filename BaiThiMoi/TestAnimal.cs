using Animal;

class Program
{
    static void Main(string[] args)
    {
        Lion l1 = new Lion();
        Tiger t1 = new Tiger();
        l1.SetMe("Lion", 100);
        l1.Show();

        t1.SetMe("Tiger", 289);
        t1.Show();

    }
}