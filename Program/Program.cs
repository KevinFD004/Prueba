namespace Program;
class Program
{
    static void Main(string[] args)
    {
        Suma sum = new Suma((n1,n2) => n1 + n2);
        Console.WriteLine(sum(12,43));
    }

    delegate int Suma(int num1, int num2);
}
