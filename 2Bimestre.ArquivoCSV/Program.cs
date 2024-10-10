//criar metodo que vai chamar o metodo lerarquivo para manipular o csv
string pastaArquivo = @"C:\Users\premier.vinicius\source\repos\files";
string arquivo = "pessoas.csv";
List<string> linhas = LerArquivo(pastaArquivo, arquivo);
//PessoasCsv(linhas);
while (true)
{
    Console.WriteLine("Executando.....");
    Executar(linhas);
    Console.WriteLine("Fim da execução");
    Thread.Sleep(5000);
}

static bool TenteConverter(string texto, out int resultado)
{
    resultado = 0;
    try
    {
        resultado = int.Parse(texto);
        return true;
    }
    catch
    {
        return false;
    }
}

static void Executar(List<string> linhas)
{
    try
    {
        PessoasCsv();
        int valor = 0;
        if (TenteConverter("123", out valor))
        {
            Console.WriteLine(valor);
        }
        else
        {
            Console.WriteLine("Valor invalido");
        }
        Console.WriteLine("Executado com sucesso");
    }
    catch (Exception erro)
    {
        Console.WriteLine("Erro ao executar");
        Console.WriteLine(erro.Message);
        Console.WriteLine(erro.StackTrace);
    }
}

static void PessoasCsv()
{
    string pasta = @"C:\Users\premier.vinicius\source\repos\files";
    var linhas = LerArquivo(pasta, "pessoas.csv");
    Console.WriteLine(linhas.Count);

    Console.Write("Digite o tipo sanguineo: ");
    string pesquisaSangue = Console.ReadLine();

    string[] colunas;

    foreach (var linha in linhas)
    {
        colunas = linha.Split(";"); // Pega a primeira coluna do arquivo, nesse caso os nomes

        var nomeCompleto = colunas[0];
        var primeiroNome = nomeCompleto.Split(' ');// pega apenas o primeiro nome dentro da coluna nomes
        var idade = colunas[1];
        var tipoSanguineo = colunas[21];
        var cidade = colunas[15];
        var estado = colunas[16];
        //nome, idade, tipo sanguineo, cidade, estado
        if (pesquisaSangue != tipoSanguineo)
        {
            continue;
        }
        Console.Write($"{primeiroNome[0]} ".PadRight(15));// retorna primeiro nome
        Console.Write($"{idade} ".PadRight(5));
        Console.Write($"{tipoSanguineo} ".PadRight(5));
        Console.WriteLine($"{cidade} - {estado}".PadRight(5));
    }
}
//criar método para ler arquivo
//metodo deve
//receber o caminho e nome do arquivo como parametro
//retornar uma lista de sttrings
static List<string> LerArquivo(string pastaArquivo, string nomeArquivo)
{
    List<string> linhas = new List<string>();
    string caminhoArquivo = Path.Combine(pastaArquivo, nomeArquivo);
    using (var sr = new StreamReader(caminhoArquivo))
    {
        string linha = sr.ReadLine();
        while (linha != null)
        {
            linhas.Add(linha);
            linha = sr.ReadLine();
        }
        sr.Close();
    }
    return linhas;
}