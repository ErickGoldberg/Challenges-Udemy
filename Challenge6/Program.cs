class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Digite o caminho completo do arquivo: ");
            string path = Console.ReadLine();

            if (File.Exists(path))
            {
                string conteudoArquivo = File.ReadAllText(path);
                string[] linhas = conteudoArquivo.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                Dictionary<string, int> votacao = new Dictionary<string, int>();

                foreach (string linha in linhas)
                {
                    string[] partes = linha.Split(',');
                    string nome = partes[0].Trim();
                    int votos = Convert.ToInt32(partes[1]);

                    if (votacao.ContainsKey(nome))
                        votacao[nome] += votos;
                    else
                        votacao[nome] = votos;  
                }

                Console.WriteLine("Resultados da votação:");
                foreach (var parChaveValor in votacao)
                {
                    Console.WriteLine($"{parChaveValor.Key}: {parChaveValor.Value} votos");
                }
            }
            else
                Console.WriteLine("O arquivo não existe.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro inesperado: {ex.Message}");
        }
    }
}
