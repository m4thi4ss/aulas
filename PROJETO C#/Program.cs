//Inserir as notas de um aluno. (Cada aluno tem 5 notas)

int[] NotaAluno = new int[5];
int SomaNotas = 0; 
int Qtdenotas = 0;

for (int i = 0; i < 5; i++)
{
   
        Console.WriteLine("Me inform a nota:");
        NotaAluno[i] = int.Parse(Console.ReadLine());
        SomaNotas = NotaAluno[i] + SomaNotas;
        Qtdenotas++;
    do
    {
        Console.WriteLine(NotaAluno[i]);
    } while (NotaAluno[i] > 0 && NotaAluno[i] < 10);
}
foreach (int i in NotaAluno)
{
    Console.WriteLine(i);
}
int media = SomaNotas / Qtdenotas;
Console.WriteLine("E a media seria:" + media);
if (media < 7)
{
    Console.WriteLine("Reprovado gato(a)");
}
else if (media >= 7)
{
    Console.WriteLine("Voce e um meninao esperto, PASSOU!!!");
}