using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Digite o caminho completo do arquivo: ");
            string path = Console.ReadLine();

            if (File.Exists(path))
            {
                string conteudoArquivo = File.ReadAllText(path);
                string[] linhas = conteudoArquivo.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                HashSet<string> nomesUnicos = new HashSet<string>();

                foreach (string linha in linhas)
                {
                    string[] partes = linha.Split(' ');

                    if (partes.Length >= 2)
                    {
                        string nome = partes[0];
                        nomesUnicos.Add(nome);
                    }
                }

                Console.WriteLine($"Número de pessoas distintas: {nomesUnicos.Count}");
            }
            else
            {
                Console.WriteLine("O arquivo não existe.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro inesperado: {ex.Message}");
        }
    }
}
