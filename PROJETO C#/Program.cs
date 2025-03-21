//Inserir as notas de um aluno. (Cada aluno tem 5 notas)

int[] NotaAluno = new int[5];
double SomaNotas = 0;
int Qtdenotas = 0;
int Lugar = 1;
//int Escolha ;

//Console.WriteLine("=== Gerenciador de Notas ===");

//Console.WriteLine("1. Cadastrar notas");
//Console.WriteLine("2. Listar notas");
//Console.WriteLine("3. Estatiscas");
//Console.WriteLine("4. Sair");


//    Console.WriteLine("Escolha uma opção:");
//    Escolha[i] = int.Parse(Console.ReadLine());
//    if(Escolha[i] == 0)




try
{
    for (int i = 0; i < 5; i++)
    {

        Console.WriteLine("Digite a " + Lugar + "ª nota:");
        NotaAluno[i] = int.Parse(Console.ReadLine());
        SomaNotas = NotaAluno[i] + SomaNotas;
        Qtdenotas++;
        Lugar++;
        if (NotaAluno[i] < 0 && NotaAluno[i] > 10)
        {
            throw new ArgumentOutOfRangeException();
        }
    }
    foreach (int i in NotaAluno)
    {
        Console.WriteLine(i);
    }
    double media = SomaNotas / Qtdenotas;
    Console.WriteLine("E a média seria:" + media);
    if (media < 7)
    {
        Console.WriteLine("O aluno foi REPROVADO!");
    }
    else if (media >= 7)
    {
        Console.WriteLine("O aluno foi APROVADO!");
    }
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine("Erro: Não pode inserir numero negativos ou acima de 10!");
}
catch (FormatException)
{
    Console.WriteLine("Erro: Não pode inserir letras!");
}

