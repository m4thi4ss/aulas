//Crie um programa que exiba os números de 1 a 20 na tela.

//int numero = 1;

//while (numero <= 20)
//{
//    Console.WriteLine(numero);
//    numero++;
//}

//Peça ao usuário para inserir a senha "1234". Continue pedindo até que ele acerte.

//int senha;

//do
//{
//    Console.WriteLine("Informe a senha: ");
//    senha = int.Parse(Console.ReadLine());
//} while (senha != 1234);

//Peça ao usuário um número e exiba a tabuada dele de 1 a 10.

//Console.WriteLine("Informe um numero: ");
//int tab = int.Parse(Console.ReadLine());

//for (int i = 0; i < 11; i++)
//{
//    Console.WriteLine(i * tab);
//}

//resposta do professor 
//Console.WriteLine("Informe um valor:");
//int valor = int.Parse(Console.ReadLine());

//for (int i = 0; i < 11; i++)
//{
//    Console.WriteLine($"{valor} * {valor * i}");
//}
//Peça um número ao usuário e faça uma contagem regressiva até 0.

//Console.WriteLine("Informe um numero:");
//int reg = int.Parse(Console.ReadLine());    

//for (int i = reg; i > 0; i--)
//{
//    Console.WriteLine(i);
//    reg ++;
//}

//Solicite notas ao usuário (entre 0 e 10) até que ele insira um número inválido. Depois, exiba a média das notas.

int nota;
int nota02 = 1;


do
{
    Console.WriteLine("informe um numero: ");
    nota = int.Parse(Console.ReadLine());
} while (nota > 0 && nota < 11);






