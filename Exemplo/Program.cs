// ESTRUTURAS CONDICIONAIS 

// ESTRUTURAS DE REPETICAO
// REPETE UMA ACAO 

// Imprimir todos os numeros de 1 a 5 
// Enquanto - While 

int numero = 1;

// Repete uma acao, ENQUANTO algo for verdade
while (numero < 6)
{
    // Se colocar somente o Console.WriteLine(numero) - ele vai imprimir o numero 1 infinitamente.
    Console.WriteLine(numero);
    //Incremento
    //numero = numero + 1 (O atalho ele faz a mesma coisa);
    numero++;
}
// Faca - Enquanto (Do/While)
//Console.WriteLine("Informe a idade: ");
//int idade = int.Parse(Console.ReadLine());

//while (idade != 22)
//{
//    Console.WriteLine("Informe a idade: ");
//    idade = int.Parse(Console.ReadLine());
//}

int idade;
do
{
    Console.WriteLine("Informe a idade: ");
    idade = int.Parse(Console.ReadLine());
} while (idade != 22);

// Para - FOR
//Quero imprimir os numeros do 1 ao 5 

//1 - Cria uma variaval chamadda i ("indice")
//2-
//3 - Incremento ao executar as chaves 
for (int i = 0; i < 6;i++) //i++ e o incremento igual o numero ++ (Caso queira pular por outro numero ao inves de 1 so usar essa conta i = i + 2)
{
    
}

// Tratamento de Execucao 
// Expection (Conjuntos de erros)
// IOException - in and out (entrada e saida)
//OverFloeException - Ele e usado quando o usuario coloca um numero muito grande que acaba transbordando 
//formatException - Erros no formato (tipo de dados)

//try/catch - Tentar/Pegar 
//Breakpoint

try
{
    Console.WriteLine(

}
//---------------------------------------------------------------------------------------------------------------------------
//Vetores 
//5 idades

int idade1;
int idade2;
int idade3;
int idade4;
int idade5;

//Conjunto de informacoes/dados
//Vetor/Array - TEM QUE TER LIMITES
int[] idades = new int[5]; //new int["Aqui dentro vai ficar a quantidade de idades que vai ser guardada"]

string[] nomes = new string[10]; //Como colocar letras 

//Crio o Vetor e dou um nome 
//int[] idades;

//Inicializo o Vetor
//new <TIPO>[<QUANTIDADE>];

//Posicao
// 0 1 2 3 4 5
nomes[0] = "Vinicio";

Console.WriteLine(nomes[0]);

idades[4] = 26;

//FOR - Percorrer Listas/Vetores
//Cadastrar todos os nomes
for (int i = 0;i < 5; i++)
{
    Console.WriteLine("Insira um nome: ");
    nomes[i] = Console.ReadLine();
}

//Listar todos os nomes
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(nomes[i]);
}

//Para cada
foreach (var item in nomes) //var ele e usado para vericar qual operador ele seria, por exemplo nomes e string ele ja vai transformar automaticamente 
{
    Console.WriteLine(item);
}

