namespace Program;
class Program
{
    static void Main(string[] args)
    {
        Suma sum = new Suma((n1,n2) => n1 + n2);
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine(sum(num1,num2));
    }

    delegate int Suma(int num1, int num2);
}
