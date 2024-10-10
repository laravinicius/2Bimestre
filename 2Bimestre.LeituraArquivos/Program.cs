string pastaArquivo = @"C:\Users\premier.vinicius\source\repos\files";
//LerArquivo(pastaArquivo, "teste.txt");
//LerArquivoLote(pastaArquivo, "textoTeste.txt");
static void LerArquivo(string pastaArquivo, string nomeArquivo)
{
    var sr = new StreamReader(Path.Combine(pastaArquivo, nomeArquivo));
    var conteudoArquivo = sr.ReadToEnd();
    string[] linhas = conteudoArquivo.Split(Environment.NewLine);
    sr.Close();
    Console.WriteLine($"Qtd Linhas: {linhas.Length}");
    Console.WriteLine(conteudoArquivo);
}
static void LerArquivoLote(string pastaArquivo, string nomeArquivo)
{
    using (var sr = new StreamReader(Path.Combine(pastaArquivo, nomeArquivo)))
    {
        string linha = sr.ReadLine();
        while (linha != null)
        {
            //Console.WriteLine(linha);
            linha = sr.ReadLine();
        }
        sr.Close();
    }
    //contains
    //quantidade de linhas
    //quantas vezes a palavra LOREM aparece
    using (var sr = new StreamReader(Path.Combine(pastaArquivo, nomeArquivo)))
    {
        string linha = sr.ReadLine();
        int qtdLinhas = 0;
        int qtdLorem = 0;
        while (linha != null)
        {
            qtdLinhas++;
            if (linha.Contains("lorem") == true)
            {
                qtdLorem++;
            }
            linha = sr.ReadLine();
        }
        Console.WriteLine($"O documento tem {qtdLinhas} linhas");
        Console.WriteLine($"A palavra lorem aparece {qtdLorem} vezes");
        sr.Close();
        for (int i = 0; i <= qtdLinhas; i++)
        {
        }
    }
    
}
