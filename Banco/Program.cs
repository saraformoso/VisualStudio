using Banco;

internal class Program
{
    private static void Main(string[] args)
    {
        Conta cb;

      


        Console.WriteLine("Entre o numero de conta: ");
        int numero=int.Parse(Console.ReadLine());

        Console.WriteLine("Entre o titular da conta: ");
        string titular = Console.ReadLine();

        Console.WriteLine("Haverá deposito inicial?:S/N ");
        char resposta = char.Parse(Console.ReadLine());
        if (resposta == 'S' || resposta == 's')
        {
            Console.WriteLine("Entre o valor de deposito:");
            double depositoInicial = double.Parse(Console.ReadLine());
            cb = new Conta(numero, titular, depositoInicial);
        }
        else {
            cb = new Conta(numero, titular);
        }
        Console.WriteLine();
        Console.WriteLine("dados da conta: ");
        Console.WriteLine(cb);
        Console.WriteLine();
        Console.WriteLine("Valor a depositar");
        double quantia = double.Parse(Console.ReadLine());
        cb.Deposito(quantia);
        Console.WriteLine("Dados actualizados");
        Console.WriteLine(cb);

        Console.WriteLine();
        Console.WriteLine("Valor a levantar");
        quantia = double.Parse(Console.ReadLine());
        cb.Levantamento(quantia);
        Console.WriteLine();
        Console.WriteLine("Dados actualizados");
        Console.WriteLine(cb);

        //cb.Titular = "Maria";
        //Console.WriteLine();
    }
}