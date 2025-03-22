//Crie um programa que exiba os números de 1 a 20 na tela.

//int numero = 1;

//while (numero <= 20)
//{
//    Console.WriteLine(numero);
//    numero++;
//}

//Peça ao usuário para inserir a senha "1234". Continue pedindo até que ele acerte.

int senha;

do
{
    Console.WriteLine("Informe a senha: ");
    senha = int.Parse(Console.ReadLine());
} while (senha != 1234);

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

//int nota;
//int somaNotas = 0;
//int qtdNotas = 0;


//do
//{
//    Console.WriteLine("informe um numero: ");
//    nota = int.Parse(Console.ReadLine());

//    if (nota >= 0 && nota <= 10) //Aqui esta informando que que se for menor que 0 vai ser falso e se for maior que 10 vai ser falso.
//    {
//        somaNotas = nota + somaNotas;//  Aqui ele ta pegando o valor da nota e somando dentro do somaNotas, fazendo com que guarde todas as notas, como por exemplo: nota = 5 vai ser 5 + 0 o somaNotas vai ser 5, acrescenta + 5 no notas, o somaNotas vai ficar 10 e assim por diante
//        qtdNotas++; //Esse ja vai calcular a quantidade de vezes que for inserido a nota
//    }

//} while (nota >= 0 && nota <= 10);

//int media = somaNotas / qtdNotas;// Vai Calcular a a soma das notas / pela quantidade de insercao de notas
//Console.WriteLine(media);

//------------------------------------------------------------------------------------------------------------------

//Tratamento de Exceções 

//Entrada Segura de Números

//try
//{
//    int nome = int.Parse(Console.ReadLine());
//}
//catch (FormatException ex)
//{
//    Console.WriteLine("Erro: Colocou uma idade fora do limite");
//}

//Crie um programa que peça dois números ao usuário e divida o primeiro pelo segundo. Use try/catch para evitar divisão por zero e entrada inválida.
//try
//{
//    Console.WriteLine("Digite o primeiro numero:");
//    int num01 = int.Parse(Console.ReadLine());

//    Console.WriteLine("Digite o segundo numero:");
//    int num02 = int.Parse(Console.ReadLine());

//    int div = num01 / num02;
//}
//catch (FormatException ex)
//{
//    Console.WriteLine("Erro: Nao e possivel dividir por zero");
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine("Erro: Nao e possivel dividir por zero");
//}

//Peça ao usuário para inserir sua idade e diga se ele é maior ou menor de idade. Use `try/catch` para evitar entradas inválidas.

//**Erros a serem tratados:**

//-Usuário digitar um texto ao invés de um número. (`FormatException`)
//- Usuário inserir um número muito grande. (`OverflowException`)



//try
//{
//    Console.WriteLine("Informe sua idade:");
//    int idade = int.Parse(Console.ReadLine());

//    if (idade >= 18)
//    {
//        Console.WriteLine("Voce e maior de idade");
//    }
//    else if (idade > 0)
//    {

//        Console.WriteLine("Voce e menor de idade");
//    }
//    if (idade < 0)
//    {
//        throw new ArgumentOutOfRangeException("Erro: A idade nao pode ser negativa");
//    }
//}
//catch (FormatException ex)
//{
//    Console.WriteLine("Erro: A idade nao pode ser negativa");
//}
//catch (OverflowException ex)
//{
//    Console.WriteLine("Erro: A idade nao pode ser negativa");
//}
//catch (ArgumentOutOfRangeException ex)
//{
//    Console.WriteLine("Erro: A idade nao pode ser negativa");
//}

//Peça ao usuário para inserir um número inteiro positivo. O programa deve contar de 1 até esse número. Se a entrada for inválida ou negativa, exiba um erro.

//**Erros a serem tratados:**

//-Usuário digitar um texto ao invés de um número. (`FormatException`)
//- Usuário inserir um número muito grande. (`OverflowException`)
//- Usuário inserir um número negativo. (`ArgumentOutOfRangeException`)



//try
//{
//    Console.WriteLine("Digite um numero: ");
//    int num01 = int.Parse(Console.ReadLine());
//    int num02 = 1;

//    while (num01 >= num02)
//    {
//        Console.WriteLine(num02);
//        num02++;
//    }
//    if (num01 < 0)
//    {
//        throw new ArgumentOutOfRangeException();
//    }
//}
//catch (OverflowException ex)
//{
//    Console.WriteLine("Erro: O numero deve ser positivo");
//}
//catch (ArgumentOutOfRangeException ex)
//{
//    Console.WriteLine("Erro: O numero deve ser positivo");
//}
//catch (FormatException ex)
//{
//    Console.WriteLine("Erro: Tem que ser um numero");
//}

//Crie um programa que solicite ao usuário uma senha e permita até 3 tentativas. Caso a senha esteja errada, informe quantas tentativas restam.

//**Erros a serem tratados:**

//-Usuário digitar um valor nulo ou vazio. (`ArgumentNullException`)

//try
//{
//    Console.WriteLine("Digite sua senha: ");
//    int senha = int.Parse(Console.ReadLine());
//    int senha2;


//    do
//    {
//        Console.WriteLine("Qual e sua senha:");
//        senha2 = int.Parse(Console.ReadLine());
//    } while (senha2 != senha);
//    if (senha = nulo); 
//    {

//    }

//}
//catch()

//------------------------------------------------------------------------------------------
//Cria um vetor de idades com 4 posicoes 

//int[] idades = new int[4];

//Use um for para preencher as idades

//for (int i = 0; i < 4; i++)
//{
//    Console.WriteLine("Insira a idade: ");
//    idades[i] = int.Parse(Console.ReadLine());
//}

//Use um for para listar as idades

//for (int i = 0; i < 4; i++)
//{
//    Console.WriteLine(idades[i]);
//}

//1. * *Listagem dos Elementos**
//    - Crie um vetor com 5 elementos, e liste todos os elementos do vetor utilizando um For

//int[] ele = new int[5];

//for(int i = 0; i < 5; i++)
//{
//    Console.WriteLine("Me informe um numero:");
//    ele[i] = int.Parse(Console.ReadLine());
//}

//for(int i = 0;i < 5; i++)
//{
//    Console.WriteLine(ele[i]);
//}

//Soma dos Elementos de um Array
//Crie um programa que declare um array de 5 números inteiros e utilize um laço de repetição para somar todos os valores. No final, exiba a soma na tela.

//int[] num = new int[5];
//int num2 = 0;

//for (int i = 0; i <= 5; i++)
//{
//    Console.WriteLine("Me informe um numero:");
//    num[i] = int.Parse(Console.ReadLine()) ;
//    num2 = num[i] + num2;
//}

//1. **Encontrar o Maior Número em um Array**
//-Crie um programa que declare um array de 5 números inteiros e utilize um laço de repetição para encontrar o maior número do array. No final, exiba o maior valor encontrado.

//int[] num3 = new int[5]; //Aqui voce ta criando um vetor pra guardar informacoes
//int num2 = 0; //Auxiliar para o IF

//for (int i = 0; i < 5; i++) //Criando uma lista de 0 a 5
//{
//    Console.WriteLine("Me informe um numero:"); //Pedindo para o usuario informar um numero
//    num3[i] = int.Parse(Console.ReadLine()); //passando o Console.Writeline para numero
//    if (num3[i] > num2) //Informando que vai pegar o maior do num3[i]
//    {
//        num2 = num3[i]; //Guardando o maior do num3[i]
//    }
//}
//Console.WriteLine(num2); //Mostrando na tela.

//1. **Remover Duplicatas**
//-Receba 10 números em um array e exiba-os sem valores duplicados.

//int[]num1 = new int[10];
//int num2 = 0;

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine("Me informe 10 numeros:");
//    num1[i] = int.Parse(Console.ReadLine());
//    num2 = new int[i];
//    if (num1[i] =  )
//}

//---------------------------------------------------------------------------------------------

double Soma(double x, double y)
{
    double resultado = x + y;

    return resultado;
}

Console.WriteLine(Soma(2, 4));