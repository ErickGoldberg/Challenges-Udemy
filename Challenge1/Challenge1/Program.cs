
using Challenge1;

internal class Program
{
    private static void Main(string[] args)
    {
        // Aula 45 - Easy

        Funcionario funcionario = new Funcionario();

        Console.Write("Nome: ");
        funcionario.Nome = Console.ReadLine();

        Console.Write("Salário Bruto: ");
        funcionario.SalarioBruto = Convert.ToDouble(Console.ReadLine());

        Console.Write("Imposto: ");
        funcionario.Imposto = Convert.ToDouble(Console.ReadLine());

        double salarioLiquido = funcionario.SalarioLiquido(funcionario.SalarioBruto, funcionario.Imposto);

        Console.WriteLine("Funcionario: " + funcionario.Nome + ", $ " + salarioLiquido);

        Console.WriteLine("Digite a porcentagem para aumentar o saláro: ");
        double porcentagem = Convert.ToDouble(Console.ReadLine());

        double salarioFinal = funcionario.AumentarSalario(porcentagem, salarioLiquido);

        Console.WriteLine("Dados atualizados: " + funcionario.Nome + ", $ " + salarioFinal);
    }
}