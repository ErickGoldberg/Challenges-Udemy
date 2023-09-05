using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        // Substitua o caminho do arquivo
        string filePath = "";

        try
        {
            string[] lines = File.ReadAllLines(filePath);

            List<Funcionario> funcionarios = lines
                .Select(line =>
                {
                    string[] parts = line.Split(',');
                    return new Funcionario
                    {
                        Nome = parts[0],
                        Email = parts[1],
                        Salario = decimal.Parse(parts[2])
                    };
                })
                .ToList();

            Console.Write("Digite o valor mínimo de salário: ");
            decimal salarioMinimo = decimal.Parse(Console.ReadLine());

            var emailsFiltrados = funcionarios
                .Where(funcionario => funcionario.Salario > salarioMinimo)
                .OrderBy(funcionario => funcionario.Email)
                .Select(funcionario => funcionario.Email);

            Console.WriteLine("\nE-mails dos funcionários com salário superior ao valor fornecido:");
            foreach (var email in emailsFiltrados)
            {
                Console.WriteLine(email);
            }

            decimal somaSalariosM = funcionarios
                .Where(funcionario => funcionario.Nome.StartsWith("M"))
                .Sum(funcionario => funcionario.Salario);

            Console.WriteLine($"\nSoma dos salários dos funcionários cujo nome começa com 'M': {somaSalariosM:C}");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Arquivo CSV não encontrado.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
        }
    }
}

class Funcionario
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public decimal Salario { get; set; }
}
