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