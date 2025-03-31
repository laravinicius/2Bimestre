static void Main(string[] args)
{
    string pastaArquivo = @"C:\Users\premier.vinicius\source\repos\files"; //@ na frente iedentifica a \, sem o @ é preciso colocar \\
    CriaPasta(pastaArquivo);
    CriaArquivoOlaMundo(pastaArquivo);
    CriarArquivoPorMes(pastaArquivo);
    CriaArquivoPorMes(pastaArquivo);
    Console.ReadKey();

}

static void CriaPasta(string pastaArquivo)
{
    if (!Directory.Exists(pastaArquivo))
    {
        Directory.CreateDirectory(pastaArquivo);
    }
    else
    {
        Console.WriteLine("Pasta não existe");
    }
}

static void CriaArquivoOlaMundo(string pastaArquivo)
{
    string nomeArquivo = "teste.txt";
    string arquivo = Path.Combine(pastaArquivo, nomeArquivo);
    using (var sw = new StreamWriter(arquivo, true))
    {
        sw.Write("Ola mundo");
        sw.WriteLine("Ola mundo2");
        sw.Close();
    }
}
static void CriarArquivoPorMes(string pastaArquivo)
{
    //escrever arquivo com Ano_Mes.txt
    //dentro do arquivo escrever uma linha por dia
    var dataAtual = DateTime.Today;
    var qtdDiasMes = DateTime.DaysInMonth(dataAtual.Year, dataAtual.Month);
    string nomeArquivo = $"{dataAtual.Year}_{dataAtual.Month}.txt";
    string arquivo = Path.Combine(pastaArquivo, nomeArquivo);
    var sw = new StreamWriter(arquivo, true);
    for (int i = 1; i <= qtdDiasMes; i++)
    {
        sw.WriteLine(i);
    }
    sw.Close();
}
static void CriaArquivoPorMes(string pastaArquivo)
{
    //criar arquivo para cada dia do mes
    //conteudo data
    // ano_mes_dia.txt

    var dataAtual = DateTime.Today;
    var qtdDiasMes = DateTime.DaysInMonth(dataAtual.Year, dataAtual.Month);
    for (int i = 1; i <= qtdDiasMes; i++)
    {
        string arquivo = Path.Combine(pastaArquivo, $"{dataAtual.Year}_{dataAtual.Month}_{i}.txt");
        var sw = new StreamWriter(arquivo, true); //append true adiciona conteudo ao arquivo, false sobreescreve o arquivo
        sw.WriteLine($"{dataAtual.Year}_{dataAtual.Month}_{i}");
        sw.Close();
    }
}